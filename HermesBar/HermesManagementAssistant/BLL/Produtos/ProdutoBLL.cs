﻿using DAO.Produtos;
using MODEL.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILS;

namespace BLL.Produtos
{
    public class ProdutoBLL
    {
        private ProdutoDAO _produtoDAO = null;
        public ProdutoDAO ProdutoDAO
        {
            get
            {
                if (_produtoDAO == null)
                    _produtoDAO = new ProdutoDAO();
                return _produtoDAO;
            }
        }
        private TipoProdutoBLL _tipoProdutoBLL = null;
        public TipoProdutoBLL TipoProdutoBLL
        {
            get
            {
                if (_tipoProdutoBLL == null)
                    _tipoProdutoBLL = new TipoProdutoBLL();
                return _tipoProdutoBLL;
            }
        }
        public bool Salvar(ProdutoModel produto)
        {
            return ProdutoDAO.Salvar(produto);
        }
        public List<ProdutoModel> Pesquisa(ProdutoModel produto)
        {
            if (produto.Tipo != null) 
                produto.Tipo = TipoProdutoBLL.PesquisaTipo(produto.Tipo);

            return ProdutoDAO.PesquisaGrid(produto).DataTableToList<ProdutoModel>();
        }
    }
}
