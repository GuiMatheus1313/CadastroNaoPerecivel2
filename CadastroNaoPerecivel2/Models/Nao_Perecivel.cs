using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroNaoPerecivel2.Models
{
    public class Nao_Pericivel
    {
        [Required(ErrorMessage = "O campo Código é obrigatório")]
        [Range(0, 1000, ErrorMessage = "O campo Código aceita de 0 a 1000")]
        [Display(Name = "Nº Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "O campo deve apresentar entre 2 a 30 caracteres")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [MaxLength(100, ErrorMessage = "A descrição não deve ultrapassar 100 caracteres")]
        [Display(Name = "Descrição do Produto")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Peso é obrigatório")]
        [Range(0.00, 100.00, ErrorMessage = "É aceito o produto apenas entre 0 a 100 KG")]
        [Display(Name = "Peso do Produto (KG)")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório")]
        [MaxLength(20, ErrorMessage = "A categoria do produto não deve ultrapassar 20 caracteres")]
        [Display(Name = "Categoria do Produto")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O campo Valor Unitário é obrigatório")]
        [Range(0.00, 200.00, ErrorMessage = "O valor do produto só pode ser inserido entre R$0,00 à R$200,00")]
        [Display(Name = "Valor Unitário do Produto")]
        public double ValorUni { get; set; }
    }
}