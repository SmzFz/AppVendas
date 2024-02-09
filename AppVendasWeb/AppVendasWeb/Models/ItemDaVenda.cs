using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }
        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Display(Name = "Código de Venda")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public Guid VendaId { get; set; }

        public Venda? Venda { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public decimal Valor { get; set; }


    }
}
