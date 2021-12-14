using System;

namespace ShippingSystem.Models
{
    public class EnderecoRota
    {

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string NumeroLogradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string PontoReferencia { get; set; }
        public DateTime DataCriacaoRota { get; set; }

        public DateTime DataCancelamentoRota { get; set; }

        public EnderecoRota PontoChegada { get; set; }

    }

}