using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EchangeDeLivres.Models
{
    public class Livre
    {
        public int IdLivre { get; set; }
        public string CodeLivre { get; set; }
        public string TitreLivre { get; set; }
        public string AuteurLivre { get; set; }
        public int NbPagesLivre { get; set; }
        public float PrixLivre { get; set; }
    }
}