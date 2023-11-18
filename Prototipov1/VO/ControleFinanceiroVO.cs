using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1
{
    class ControleFinanceiroVO
    {

        private ControleFinanceiro cdao;
        private String _data_mov, _descricao, _descr_conta, _descr_ativo, _doador, _doador_id;
        private Double _valor;


        public ControleFinanceiroVO()
        {

        }

        
        public String data_mov
        {
            get { return _data_mov; }
            set { _data_mov = value; }
        }
        public String descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public String descr_conta
        {
            get { return _descr_conta; }
            set { _descr_conta = value; }
        }

        public String descr_ativo
        {
            get { return _descr_ativo; }
            set { _descr_ativo = value; }
        }

        public String doador_id
        {
            get { return _doador_id; }
            set { _doador_id = value; }
        }
        public String doador
        {
            get { return _doador; }
            set { _doador = value; }
        }

        public Double valor
        {
            get { return _valor; }
            set { _valor = value; }
        }




        public void InserirFinanceiro()
        {
            cdao = new ControleFinanceiro();
            cdao.InserirDados(data_mov, descricao, valor, doador, descr_conta, descr_ativo);
        }
        public void AtualizarFinanceiro()
        {
            cdao = new ControleFinanceiro();
            cdao.AtualizarDados(data_mov, descricao, valor, doador, descr_conta, descr_ativo);
        }
        public void RemoverFinanceiro()
        {
            cdao = new ControleFinanceiro();
            cdao.RemoverDados(data_mov, descricao, valor, doador, descr_conta, descr_ativo);
        }
    }
}

