﻿using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
    public class Cliente
    {

        public Guid ClienteId { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres")]
        public string ClienteNome { get; set; }
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 20 caracteres")]
        public string CPF { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 150 caracteres")]
        public string Email { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]

        public DateOnly DataNascimento { get; set; }
        [Display(Name = "Celular")]
        [Required(ErrorMessage = "O campo Celular é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 20 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Cadastro Ativo")]
        public bool CadastroAtivo { get; set; }
    }
}
