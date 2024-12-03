using Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Events;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basis.Desafio.Core.Domain.Aggregates.CommonAgg.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string IdExterno { get; set; }
        DateTime? CriadoEm { get; set; }
    }

    public class Entity : IEntity
    {
        [NotMapped]
        private List<BaseEvent> _domainEvents;

        public Entity()
        {
            CriadoEm ??= DateTime.UtcNow;
            _idExterno ??= Guid.NewGuid().ToString();
        }

        string _idExterno;
        public string IdExterno
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_idExterno))
                {
                    CriadoEm ??= DateTime.UtcNow;
                    _idExterno = Guid.NewGuid().ToString();
                }
                return _idExterno;
            }
            set { this._idExterno = value; }
        }

        [DisplayName("Criado em")]
        public DateTime? CriadoEm { get; set; } = DateTime.UtcNow;

        [DisplayName("Atualizado em")]
        public DateTime? AtualizadoEm { get; set; }

        [DisplayName("Deletado em")]
        public DateTime? DeletadoEm { get; set; }

        public virtual void Updated()
        {
            this.AtualizadoEm = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        public bool Deletado { get; set; }

        [NotMapped]
        public List<BaseEvent> DomainEvents { get { return _domainEvents; } set { _domainEvents = _domainEvents ?? value; } }

        public void Delete()
        {
            this.Deletado = true;
            this.DeletadoEm = DateTime.UtcNow;
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        public void AddDomainEvent(BaseEvent domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<BaseEvent>();
            _domainEvents.Add(domainEvent);
        }

        public bool IsEmpty()
        {
            return this.IsEmpty();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not IEntity) return false;

            return ((Entity)obj)?.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
    }
}
