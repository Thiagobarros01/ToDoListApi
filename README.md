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

2. Configure a conexão com o banco de dados no arquivo appsettings.json:
 
{
  "ConnectionStrings": {
    "DefaultConnection": "// Preencha aqui com sua connection string"
  }
}
Execute as migrações do banco de dados:

dotnet ef database update
Inicie a aplicação:

dotnet run
Acesse a API no navegador em https://localhost:7079/swagger para testar os endpoints com Swagger.

🗃️ Estrutura de Dados
Modelo TarefaModel
public class TarefaModel {
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }
}
Modelo ResponseModel<T>
public class ResponseModel<T> {
    public T? Dados { get; set; }
    public string Mensagem { get; set; }
    public bool Status { get; set; }
}
🌐 Endpoints
1. Obter Todas as Tarefas
GET /api/Tarefas/ObterTarefas

Exemplo de Resposta:

{
  "status": true,
  "mensagem": "Tarefas obtidas com sucesso!",
  "dados": [
    {
      "id": 1,
      "titulo": "Minha primeira tarefa",
      "descricao": "Descrição da tarefa",
      "concluida": false
    }
  ]
}
2. Obter Tarefa por ID
GET /api/Tarefas/ObterTarefaPorId/{id}

Exemplo de Resposta:

{
  "status": true,
  "mensagem": "",
  "dados": {
    "id": 1,
    "titulo": "Minha primeira tarefa",
    "descricao": "Descrição da tarefa",
    "concluida": false
  }
}
3. Criar Tarefa
POST /api/Tarefas/CriarTarefa

Exemplo de Payload:

{
  "titulo": "Nova Tarefa",
  "descricao": "Descrição da nova tarefa"
}
Exemplo de Resposta:

{
  "status": true,
  "mensagem": "Tarefa criada com sucesso",
  "dados": [
    {
      "id": 1,
      "titulo": "Nova Tarefa",
      "descricao": "Descrição da nova tarefa",
      "concluida": false
    }
  ]
}
4. Atualizar Tarefa
PUT /api/Tarefas/AtualizarTarefa/{id}

Exemplo de Payload:

{
  "titulo": "Tarefa Atualizada",
  "descricao": "Descrição atualizada",
  "concluida": true
}
Exemplo de Resposta:

{
  "status": true,
  "mensagem": "Tarefa atualizada com sucesso!",
  "dados": {
    "id": 1,
    "titulo": "Tarefa Atualizada",
    "descricao": "Descrição atualizada",
    "concluida": true
  }
}
5. Excluir Tarefa
DELETE /api/Tarefas/DeletarTarefa/{id}

Exemplo de Resposta:

{
  "status": true,
  "mensagem": "Tarefa excluída com sucesso",
  "dados": {
    "id": 1,
    "titulo": "Tarefa excluída",
    "descricao": "Descrição",
    "concluida": false
  }
}
🛡️ Tratamento de Erros
404 Not Found: Tarefa não encontrada.
500 Internal Server Error: Erro no servidor ou banco de dados.
🤝 Contribuição
Contribuições são bem-vindas!
Faça um fork do projeto e envie um pull request com suas alterações.

