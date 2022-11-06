using Microsoft.AspNetCore.Mvc.Formatters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelerAPI.Models
{
    [Table("Servico")]
    public class Servico
    {
        [Key]
        public String codServico { get; set; }
        [Required(ErrorMessage = "Informe a descricao do servico")]
        [StringLength(200)]
        public string descricao { get; set; }
        [Required(ErrorMessage = "Informe o valor do servico")]
        public decimal valorServico { get; set; }
        [Required(ErrorMessage = "Informe o tipo do servico")]
        [StringLength(20)]
        public string tipoServico { get; set; } 
         

    }
}

