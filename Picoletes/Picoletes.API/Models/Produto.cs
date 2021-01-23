using System;
using System.Collections.Generic;
using System.Text;

namespace Picoletes.Dominio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ValidadeForaFreezer { get; set; }
    }
}
