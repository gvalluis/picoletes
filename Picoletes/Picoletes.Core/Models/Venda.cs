﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Picoletes.Core.Models
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public string CodigoProduto { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public int QuantidadeVendida { get; set; }
    }
}
