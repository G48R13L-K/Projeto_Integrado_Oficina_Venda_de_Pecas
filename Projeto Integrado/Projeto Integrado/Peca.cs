using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projeto_Integrado
{
    public class Peca 
    {
        
       
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string NomePeca { get; set; }
        public string DescricaoPeca { get; set; }
        public decimal PrecoPeca { get; set; }
        public int QuantidadePeca { get; set; }

        
    }
}