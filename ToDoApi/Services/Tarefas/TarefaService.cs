using Microsoft.EntityFrameworkCore;
using ToDoApi.Data;
using ToDoApi.Dto.Tarefa;
using ToDoApi.Models;

namespace ToDoApi.Services.Tarefas
{
    public class TarefaService : ITarefaInterface
    {

        private readonly AppDbContext _context;

        public TarefaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<TarefaModel>> AtualizarTarefa(int id, TarefaEdicaoDto tarefaAtualizada)
        {
            ResponseModel<TarefaModel> resposta = new ResponseModel<TarefaModel>();

            try
            {
                var tarefa = await _context.tarefas.FirstOrDefaultAsync(t => t.Id == id);
                if (tarefa == null) 
                {
                    resposta.Mensagem = "Tarefa não encontrada!";
                    resposta.Status = false;
                    return resposta;
                }



                tarefa.Titulo = tarefaAtualizada.Titulo;
                tarefa.Concluida = tarefaAtualizada.Concluida;
                tarefa.Descricao = tarefaAtualizada.Descricao;

                

                _context.Update(tarefa);
                await _context.SaveChangesAsync();
                resposta.Status = true;
                resposta.Mensagem = "Tarefa atualizada com sucesso!";
                resposta.Dados = tarefa;
                return resposta;



            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<TarefaModel>>> CriarTarefa(TarefaCriacaoDto novaTarefa)
        {
            ResponseModel<List<TarefaModel>> resposta = new ResponseModel<List<TarefaModel>>();

            try
            {
                var newTarefa = new TarefaModel()
                {
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
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                return resposta;
            }


        }

        public async Task<ResponseModel<TarefaModel>> DeletarTarefa(int id)
        {
            ResponseModel<TarefaModel> resposta = new ResponseModel<TarefaModel>();

            try { 
            var tarefa = await _context.tarefas.FirstOrDefaultAsync(t => t.Id == id);
               
                if (tarefa == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Tarefa não encontrada.";
                    return resposta;
                }
            _context.tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
            resposta.Dados = tarefa;
            resposta.Status = true;
            resposta.Mensagem = "Tarefa excluída com sucesso";
            return resposta;
            }
            catch (Exception e)
            {
                Console.WriteLine($"VIM PRA CA, meu valor Resposta: {resposta}, meu valor {resposta.Dados}");
                resposta.Mensagem = e.Message;
                resposta.Status = false;
                return resposta;
            }



        }

        public async Task<ResponseModel<TarefaModel>> ObterTarefaPorId(int id)
        {
            ResponseModel<TarefaModel> resposta = new ResponseModel<TarefaModel>();
            try
            {

                var tarefa = await _context.tarefas.FirstOrDefaultAsync(t => t.Id == id);
                if (tarefa == null)
                {
                    resposta.Mensagem = "Tarefa não encontrada";
                    return resposta;
                }

                resposta.Dados = tarefa;
                resposta.Status = true;
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                return resposta;

            }
        }

        public async Task<ResponseModel<List<TarefaModel>>> ObterTarefas()
        {
            ResponseModel<List<TarefaModel>> resposta = new ResponseModel<List<TarefaModel>>();
            try
            {
                var tarefas = await _context.tarefas.ToListAsync();
                resposta.Dados = tarefas;
                resposta.Status = true;
                resposta.Mensagem = "Tarefas obtidas com sucesso!";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }


        }
    }
}
