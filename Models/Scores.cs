using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShippingSystem.Models
{
    public class Scores : DbContext
    {
        public Scores() : base("") { }
        public int IdScores { get; set; }
        public int Classificacao { get; set; }
        public string Referencias { get; set; }
        public int Pontos { get; set; }
         
        public string Comentarios { get; set; }
        public string NotaClassificacao { get; set; }


        public DbSet<Scores> All { get; set}


        public void Save() 
        {
            this.All(this);
            this.SaveChanges();
        }
    }
}