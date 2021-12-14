using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShippingSystem.Models
{
    public class PedidoFrete
    {

        public int IdPedido { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPedido { get; set; }
        public Cancelamentos DataCancelamentoPedido { get; set; }
        public int  IdRota { get; set; }
        public int IdCliente { get; set; }
        public int IdMotorista { get; set; }
        public int IdVeiculo { get; set; }

        public string logPedido { get; set; }
    }

    public class Cancelamentos
    {
        public int IdCancelamento { get; set; }
        public int IdPedido { get; set; }
        public double GerouValor { get; set; }
        public DateTime HorarioCancelamento { get; set; }
        public string MotivoCancelamento { get; set; }

    }
}