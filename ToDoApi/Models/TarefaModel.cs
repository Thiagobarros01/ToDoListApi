using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Models {
    public class TarefaModel {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; } = false;
        public DateTime DataCriacao { get; set; } = DateTime.Now;


    }
}
