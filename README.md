# 📋 ToDoApi

API RESTful desenvolvida com **ASP.NET Core** e **SQL Server**, destinada ao gerenciamento de tarefas. A aplicação fornece endpoints para criação, consulta, atualização e exclusão de tarefas, além de tratar respostas padronizadas.

---

## 📖 Descrição

A **ToDoApi** é uma API simples que gerencia tarefas, implementando boas práticas de desenvolvimento como:
- **Arquitetura em Camadas**.
- **Injeção de Dependência** para desacoplamento.
- Tratamento de erros amigável e padronizado.

A aplicação utiliza **SQL Server** como banco de dados e **Entity Framework Core** para mapeamento objeto-relacional.

---

## 💻 Tecnologias Utilizadas

- **ASP.NET Core 8**
- **Entity Framework Core**
- **SQL Server**
- **Swagger UI** (para documentação interativa)
- **Injeção de Dependência**

---

## ⚙️ Funcionalidades

- **Criar Tarefa**: Adicione novas tarefas ao sistema.
- **Obter Tarefas**: Consulte todas as tarefas registradas.
- **Obter Tarefa por ID**: Consulte os detalhes de uma tarefa específica.
- **Atualizar Tarefa**: Modifique informações de uma tarefa existente.
- **Excluir Tarefa**: Remova uma tarefa do sistema.

---

## 🛠️ Configuração e Execução

### Pré-requisitos

1. **SDK .NET 8** instalado ([download aqui](https://dotnet.microsoft.com/download)).
2. **SQL Server** configurado e em execução.
3. **Ferramenta de gerenciamento de banco de dados** (como SQL Server Management Studio).

### Passos

1. Clone este repositório:
   ```bash
   git clone https://github.com/Thiagobarros01/ToDoListApi.git
   cd ToDoApi
