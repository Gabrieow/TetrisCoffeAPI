# Tetris Coffe API ☕

API RESTful para gerenciamento de uma cafeteria, incluindo o controle de vendas, estoque, clientes, produtos e muito mais.

## Sobre o Projeto

Tetris Coffe é uma ideia de cafeteria que tive com uma amiga: um ambiente acolhedor voltado à confraternização entre amigos, unindo duas coisas incríveis da vida — Café e Tetris!  
A realização dessa cafeteria ainda é um sonho que desejo concretizar. Enquanto isso, este projeto é uma forma de dar vida à ideia através da tecnologia.

---

Este sistema foi desenvolvido com o objetivo de aplicar os seguintes conceitos:

- Arquitetura em Camadas
- Integração com banco de dados SQL
- Testes unitários
- Dockerização
- Autenticação JWT

## Estrutura do Projeto

- `API` — Endpoints HTTP e configuração do ASP.NET Core
- `Application` — Lógica de negócio e serviços de aplicação
- `Domain` — Entidades e regras do domínio
- `Infrastructure` — Serviços externos (ex: autenticação, logs)
- `Persistence` — Acesso e configuração do banco de dados (EF Core)
- `Tests` — Testes unitários e/ou de integração

## Tecnologias Utilizadas

- C# 12
- ASP.NET Core
- Entity Framework Core
- SQL Server

## Como Rodar

```bash
dotnet build
dotnet run --project TetrisCoffeAPI.API
```

