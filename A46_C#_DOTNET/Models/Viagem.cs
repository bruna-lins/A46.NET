using Agencia46.Enum;
using System;

namespace Agencia46.Models
{
    public class Viagem
    {
        public int Id_Viagem { get; set; }
        public int Id_Origem { get; set; }
        public string Id_Destino { get; set; }
        public string Id_Pagamento { get; set; }
        public Tipo_pag Tipo_pag { get; set; }
        public int Parcelas { get; set; }
        public DateTime data_pagamento { get; set; }
    }
}
