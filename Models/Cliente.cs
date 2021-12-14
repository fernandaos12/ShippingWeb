using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShippingSystem.Models
{
    public class Cliente 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Logradouro { get; set; }
        public string NumeroLogradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string PontoReferencia { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public DateTime InicioCadastro { get; set; }
        public DateTime EncerramentoCadastro { get; set; }
        public Scores Pontos { get; set; }
        public Scores Classificacao { get; set; }


    }
}