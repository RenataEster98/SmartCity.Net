using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCity.Net.Models
{
    public class TipoProduto
    {
        public int IdTipo { get; set; }
        public String DescricaoTipo { get; set; }
        public bool Comercializado { get; set; }
    }
}