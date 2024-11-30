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
    }
}