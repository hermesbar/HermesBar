﻿using BLL.Fornecedor;
using MODEL.Fornecedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HermesManagementAssistant.View.Fornecedor
{
    /// <summary>
    /// Interaction logic for Fornecedor.xaml
    /// </summary>
    public partial class Fornecedor : Window
    {
        private FornecedorBLL _fornecedorBLL = null;
        public FornecedorBLL FornecedorBLL
        {
            get
            {
                if (_fornecedorBLL == null)
                    _fornecedorBLL = new FornecedorBLL();
                return _fornecedorBLL;
            }
        }
        public Fornecedor()
        {
            InitializeComponent();
            gridPesquisa.ItemsSource = FornecedorBLL.Pesquisar(new FornecedorModel() { RazaoSocial = "" });
        }
        public void Pesquisar(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCodigo.Text))
                gridPesquisa.ItemsSource = FornecedorBLL.Pesquisar(new FornecedorModel() { Id = int.Parse(tbCodigo.Text), RazaoSocial = tbRazaoSocial.Text });
            else
                gridPesquisa.ItemsSource = FornecedorBLL.Pesquisar(new FornecedorModel() { RazaoSocial = tbRazaoSocial.Text });
        }
        public void CadastrarFornecedor(object sender, RoutedEventArgs e)
        {
            new FornecedorCadastro().Show();
        }
    }
}
