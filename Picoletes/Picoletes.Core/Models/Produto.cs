using System;
using System.Collections.Generic;
using System.Text;

namespace Picoletes.Core.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int ValidadeForaFreezer { get; set; }
    }
}
