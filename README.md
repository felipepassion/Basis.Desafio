# Sistema de Cadastro de Livros

## Visão Geral

O **Sistema de Cadastro de Livros** é uma aplicação desenvolvida com foco em modularidade, separação de responsabilidades e alta testabilidade. Utilizando uma arquitetura em camadas, o sistema garante um baixo acoplamento entre os componentes, facilitando a manutenção e escalabilidade.

## Arquitetura do Sistema

A arquitetura é dividida nas seguintes camadas:

### 1. Apresentação (API)
- **Tecnologias:** ASP.NET Core, Swagger
- **Funções:**
  - Exposição de endpoints REST para interação com o sistema.
  - Validação de requisições HTTP e formatação de respostas em JSON.
  - Controle do fluxo de dados entre as camadas de aplicação e apresentação.

### 2. Aplicação
- **Tecnologias:** .NET 8, MediatR, FluentValidation
- **Funções:**
  - Implementação da lógica de negócio e regras do sistema.
  - Orquestração entre entidades de domínio e repositórios de dados.
  - Definição de casos de uso e serviços para operações específicas.

### 3. Domínio
- **Tecnologias:** .NET 8, C#
- **Funções:**
  - Representação das entidades centrais (Livro, Autor, Assunto) e suas regras.
  - Independência de tecnologias de infraestrutura, focando nos conceitos de negócio.

### 4. Infraestrutura
- **Tecnologias:** .NET 8, Entity Framework Core, PostgreSQL, Npgsql
- **Funções:**
  - Persistência de dados e gerenciamento de banco de dados.
  - Configuração do banco, mapeamento objeto-relacional e execução de queries.

### 5. Cross-Cutting
- **Tecnologias:** .NET 8, Serilog
- **Funções:**
  - Componentes transversais como logging, tratamento de exceções e utilitários.
  - Centralização de funcionalidades comuns para evitar duplicação de código.

## Fluxo de Execução

1. **Requisição HTTP**: Recebida pela camada de Apresentação (API).
2. **Controle**: O controlador delega a execução para um caso de uso na camada de Aplicação.
3. **Processamento**: O caso de uso utiliza serviços de aplicação para realizar a lógica de negócio.
4. **Persistência**: Interação com os repositórios na camada de Infraestrutura para acessar o banco de dados PostgreSQL.
5. **Resposta**: O resultado é retornado à camada de Apresentação, que formata e envia a resposta ao cliente.

## Benefícios

- **Separação de Responsabilidades:** Facilita a compreensão e manutenção do código.
- **Modularidade:** Permite desenvolvimento e testes independentes de cada módulo.
- **Testabilidade:** Camadas isoladas garantem maior qualidade do código.
- **Reutilização:** Componentes transversais são reutilizados em diferentes partes do sistema.
- **Escalabilidade:** Facilita o escalonamento independente de cada camada.

## Tecnologias Utilizadas

- **Backend:** ASP.NET Core, .NET 8, C#
- **Banco de Dados:** PostgreSQL, Entity Framework Core, Npgsql
- **Padrões e Bibliotecas:** MediatR, FluentValidation, Serilog, Swagger

## Como Usar

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [PostgreSQL](https://www.postgresql.org/download/)
- [Git](https://git-scm.com/downloads)

### Passo a Passo

1. Rodar o Projeto Migrations.Api para criação do banco de dados
2. Rodar o projeto Livratia.Api
3. Executar o swager para testar os endpoints de Assuntos, Autores e Livros
4. Um .json do POSTMAN está disponibilizado na raiz do projeto para exemplo de requisições
