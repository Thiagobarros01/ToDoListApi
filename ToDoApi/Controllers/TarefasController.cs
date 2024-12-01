using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApi.Dto.Tarefa;
using ToDoApi.Models;
using ToDoApi.Services.Tarefas;

namespace ToDoApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase {

        private readonly ITarefaInterface _itarefaInterface;
        public TarefasController(ITarefaInterface tarefaInterface) {
            _itarefaInterface = tarefaInterface;
        }

        [HttpGet("ObterTarefas")]
        public async Task<ActionResult<ResponseModel<List<TarefaModel>>>> ObterTarefas() {
                
            var tarefas = await _itarefaInterface.ObterTarefas();
            return Ok(tarefas);

        }
        [HttpGet("ObterTarefaPorId/{id}")]
        public async Task<ActionResult<ResponseModel<TarefaModel>>> ObterTarefaPorId(int id) {
            
            var tarefa = await _itarefaInterface.ObterTarefaPorId(id);
            return Ok(tarefa);
        }

        [HttpPost("CriarTarefa")]
        public async Task<ActionResult<ResponseModel<List<TarefaModel>>>> CriarTarefa(TarefaCriacaoDto criarTarefa) {
            var tarefa = await _itarefaInterface.CriarTarefa(criarTarefa);
            return Ok(tarefa);
        }

        [HttpPut("AtualizarTarefa/{idTarefa}")]
        public async Task<ActionResult<ResponseModel<TarefaModel>>> AtualizarTarefa(int idTarefa, TarefaEdicaoDto tarefaEdicaoDto)
        {
            var tarefa = await _itarefaInterface.AtualizarTarefa(idTarefa, tarefaEdicaoDto);
            return Ok(tarefa);
        }

        [HttpDelete("DeletarTarefa/{idTarefa}")]
        public async Task<ActionResult<ResponseModel<TarefaModel>>> DeletarTarefa(int idTarefa)
        {
            var tarefa = await _itarefaInterface.DeletarTarefa(idTarefa);
            return Ok(tarefa);
        }
    }
}