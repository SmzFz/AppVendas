using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Categoria
    {


        public Guid CategoriaId { get; set; }

        [Display(Name = "Nome da Categoria")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres")]
        public string CategoriaNome { get; set; }
    }
}
