using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Dto.Tarefa {
    public class TarefaCriacaoDto {
       
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
