using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShippingSystem.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public string AnoFabricacao { get; set; }
        public string Chassi { get; set; } 
        public DateTime DataCadastro { get; set; }
        public DateTime DataEncerramentoCadastro { get; set; }
        public double SuportaKg { get; set; }
        public string Categoria { get; set; }
        public int IdMotorista { get; set; }
    }
}