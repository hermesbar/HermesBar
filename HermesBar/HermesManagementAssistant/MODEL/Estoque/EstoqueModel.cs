﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Produto;
using MODEL.Abstract;

namespace MODEL.Estoque
{
    public class EstoqueModel : IModel
    {
        public ProdutoModel Produto { get; set; }
        public double QuantidadeEstoque { get; set; }
        public double EstoqueMinimo { get; set; }
        public double EstoqueIdeal { get; set; }
    }
}
