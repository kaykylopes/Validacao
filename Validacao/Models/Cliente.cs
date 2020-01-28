using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Validacao.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage =  "o Nome deve ser Informado")]
        [StringLength(50, MinimumLength =5,ErrorMessage = "o Nome deve ter no minimo 5 caractere e maximo 50")]
        [Display(Name ="Informe o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o Email deve ser Informado")]
        [EmailAddress(ErrorMessage = "Informe o Email válido")]
        [Remote("ValidaEmailDisponivel","Cliente",ErrorMessage = "Email já cadastrado na base de dados")]
        public string Email { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "o Telefone deve ter no minimo 6 caractere e maximo 10")]
        public string Telefone { get; set; }

        [Range(21,99, ErrorMessage ="A idade deve ser maior que 21 e menor que 99")]
        public int Idade { get; set; }
    }
}