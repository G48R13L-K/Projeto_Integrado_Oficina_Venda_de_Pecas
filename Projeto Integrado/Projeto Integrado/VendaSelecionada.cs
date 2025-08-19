using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_Integrado
{
    public class VendaSelecionada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClienteId { get; set; }

        public Usuario Cliente { get; set; } // Navegação para o cliente
        public int PecaId { get; set; }

        public Peca Peca { get; set; } // Navegação para a peça vendida
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }

    }
}