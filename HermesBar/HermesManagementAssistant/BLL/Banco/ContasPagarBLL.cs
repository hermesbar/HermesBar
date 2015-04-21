﻿using MODEL.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Banco;

namespace BLL.Banco
{
    public class ContasPagarBLL
    {
        private ContasPagarDAO _contasPagarDAO = null;
        public ContasPagarDAO ContasPagarDAO
        {
            get
            {
                if (_contasPagarDAO == null)
                    _contasPagarDAO = new ContasPagarDAO();
                return _contasPagarDAO;
            }
        }

        public bool Salvar(ContasPagarModel contasPagar)
        {
            try
            {
                return ContasPagarDAO.Salvar(contasPagar);
            }
            catch (Exception e)
            {
                UTIL.Session.MensagemErro = e.Message;
                return false;
            }
        }
    }
}
