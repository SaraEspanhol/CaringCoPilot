using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1
{
    internal class ControleFinanceiroVO
    {

        private ControleFinanceiro cdao;
        private int _ong_id;
        private string _data_mov, _descricao, _nome_conta, _nome_ativo, _nome_doador;
        private double _valor;


        public ControleFinanceiroVO()
        {

        }

        public int ong_id
        {
            get { return _ong_id; }
            set { _ong_id = value; }
        }
        public string data_mov
        {
            get { return _data_mov; }
            set { _data_mov = value; }
        }
        public string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        public string nome_conta
        {
            get { return _nome_conta; }
            set { _nome_conta = value; }
        }

        public string nome_ativo
        {
            get { return _nome_ativo; }
            set { _nome_ativo = value; }
        }

        public string nome_doador
        {
            get { return _nome_doador; }
            set { _nome_doador = value; }
        }

        public double valor
        {
            get { return _valor; }
            set { _valor = value; }
        }




        public void Inserir()
        {
            cdao = new ControleFinanceiro();
            cdao.InserirDados(data_mov, descricao, nome_conta, nome_ativo, valor, nome_doador);
        }
        public void Atualizar()
        {
            cdao = new ControleFinanceiro();
            cdao.AtualizarDados(ong_id, data_mov, descricao, nome_conta, nome_ativo, valor, nome_doador);
        }
        public void Remover()
        {
            cdao = new ControleFinanceiro();
            cdao.RemoverDados(ong_id, data_mov, descricao, nome_conta, nome_ativo, valor, nome_doador);
        }
    }
}

