using System;
using System.Collections.Generic;
using System.Text;

namespace Picoletes.API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ValidadeForaFreezer { get; set; }
    }
}
