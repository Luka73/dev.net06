﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Entities
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produtos()
        {

        }

        public Produtos(int idProduto, string nome, decimal preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
        }
    }
}
