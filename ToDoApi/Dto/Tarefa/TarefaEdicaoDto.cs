using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Dto.Tarefa
{
    public class TarefaEdicaoDto
    {
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; } = false;
    }
}
