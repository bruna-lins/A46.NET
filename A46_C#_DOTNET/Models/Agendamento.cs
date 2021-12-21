namespace Agencia46.Models
{
    public class Agendamento
    {
        public int Id_Agendamento { get; set; }
        public int Id_Viagem { get; set; }
        public int Id_Cliente { get; set; }
        public int Num_Voo { get; set; }
        public int Assento { get; set; }

    }
}
