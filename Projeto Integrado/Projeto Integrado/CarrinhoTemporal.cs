using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Integrado
{
    public class CarrinhoTemporal
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
