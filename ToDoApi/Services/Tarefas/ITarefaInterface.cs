using ToDoApi.Models;
using ToDoApi.Dto.Tarefa;
namespace ToDoApi.Services.Tarefas {
    public interface ITarefaInterface {
        
        Task<ResponseModel<List<TarefaModel>>> ObterTarefas();
        Task<ResponseModel<TarefaModel>> ObterTarefaPorId(int id);
        Task<ResponseModel<List<TarefaModel>>> CriarTarefa(TarefaCriacaoDto novaTarefa);
        Task<ResponseModel<TarefaModel>>AtualizarTarefa(int id, TarefaModel tarefaAtualizada);
        Task<ResponseModel<TarefaModel>> DeletarTarefa(int id);

    }
}
