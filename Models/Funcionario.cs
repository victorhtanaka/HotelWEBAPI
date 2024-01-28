using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelWEBAPI.Models
{
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }

        [Required]
        [StringLength(15)]
        public string? CargoFuncionario { get; set; }

        [Required]
        [StringLength(50)]
        public string? NomeFuncionario { get; set; }

        [StringLength(16)]
        public string? TelFuncionario { get; set; }

        [ForeignKey("Filial")]
        public int FkFilialCodFilial { get; set; }

        public virtual Filial? Filial { get; set; }
    }
}