using System.ComponentModel.DataAnnotations;

namespace HotelWEBAPI
{
    public class Funcionario
    {
        public int CodFuncionario { get; set; }
        public string CargoFuncionario { get; set; }
        public string NomeFuncionario { get; set; }
        public string TelFuncionario { get; set; }
        public int FkFilialCodFilial { get; set; }

        public Filial Filial { get; set; }
    }

}