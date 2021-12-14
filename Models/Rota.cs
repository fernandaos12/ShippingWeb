using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShippingSystem.Models
{
    public class Rota
    {
        public int IdRota { get; set; }
        public string Descricao { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public EnderecoRota PontoPartida { get; set; }
        public EnderecoRota PontoChegada { get; set; }

        public int IdMotorista { get; set; }
        public int IdCliente { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime HorarioRota { get; set; }

        public int SolicitacaoRota { get; set; }
    }
}