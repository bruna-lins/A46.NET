using Agencia46.Enum;

namespace Agencia46.Models
{
    public class Destinos
    {
        public int Id_Destino { get; set; }
        public string Nome_Dest { get; set; }
        public string Pais { get; set; }
        public double Preco { get; set; }
        public Status Status { get; set; }
    }
}
