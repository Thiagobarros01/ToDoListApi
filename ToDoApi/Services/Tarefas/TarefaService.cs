using Microsoft.EntityFrameworkCore;
using ToDoApi.Data;
using ToDoApi.Dto.Tarefa;
using ToDoApi.Models;

namespace ToDoApi.Services.Tarefas {
    public class TarefaService : ITarefaInterface {

        private readonly AppDbContext _context;

        public TarefaService(AppDbContext context) {
            _context = context;
        }

        public Task<ResponseModel<TarefaModel>> AtualizarTarefa(int id, TarefaModel tarefaAtualizada) {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<TarefaModel>>> CriarTarefa(TarefaCriacaoDto novaTarefa) {
            ResponseModel<List<TarefaModel>> resposta = new ResponseModel<List<TarefaModel>>();

            try {
                var newTarefa = new TarefaModel() {
                    Titulo = novaTarefa.Titulo,
                    Descricao = novaTarefa.Descricao
                };

                _context.Add(newTarefa);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.tarefas.ToListAsync();
                resposta.Status = true;
                resposta.Mensagem = "Tarefa criada com sucesso";
                return resposta;
            }
            catch (Exception ex) { 
                resposta.Mensagem = ex.Message;
                return resposta;
            }


        }

        public Task<ResponseModel<TarefaModel>> DeletarTarefa(int id) {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<TarefaModel>> ObterTarefaPorId(int id) {
            ResponseModel<TarefaModel> resposta = new ResponseModel<TarefaModel>();
            try {
                
                var tarefa = await _context.tarefas.FirstOrDefaultAsync(t => t.Id == id);
                if (tarefa == null) {
                    resposta.Mensagem = "Tarefa não encontrada";
                    return resposta;
                }
                
                resposta.Dados = tarefa;
                resposta.Status = true;
                return resposta;

            }
            catch (Exception ex) {
                resposta.Mensagem = ex.Message;
                return resposta;

            }
        }

        public async Task<ResponseModel<List<TarefaModel>>> ObterTarefas() {
            ResponseModel<List<TarefaModel>> resposta = new ResponseModel<List<TarefaModel>>();
            try {
                var tarefas = await _context.tarefas.ToListAsync();
                resposta.Dados = tarefas;
                resposta.Status = true;

                return resposta;
            }
            catch (Exception ex) { 
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }


        }
    }
}
