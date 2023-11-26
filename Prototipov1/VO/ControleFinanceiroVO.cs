using Prototipov1.Helpers;
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
        private String _data_mov, _descricao, _descr_conta, _descr_ativo, _tipo_conta;
        private Double _valor;
        private Int32 _ong_id, _conta_id, _ativo_id, _id;


        public ControleFinanceiroVO()
        {

        }

        public Int32 id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String data_mov
        {
            get
            {
                _data_mov = Validacoes.ValidaData(_data_mov);
                return _data_mov;
            }
            set { _data_mov = value; }
        }
        public String descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public Int32 conta_id
        {
            get { return _conta_id; }
            set { _conta_id = value; }
        }
        public String tipo_conta
        {
            get { return _tipo_conta; }
            set { _tipo_conta = value; }
        }

        public String descr_conta
        {
            get { return _descr_conta; }
            set { _descr_conta = value; }
        }

        public Int32 ativo_id
        {
            get { return _ativo_id; }
            set { _ativo_id = value; }
        }

        public String descr_ativo
        {
            get { return _descr_ativo; }
            set { _descr_ativo = value; }
        }


        public Double valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public Int32 ong_id
        {
            get { return _ong_id; }
            set { _ong_id = value; }
        }



        public void InserirFinanceiro()
        {
            if (descricao == "" || descr_ativo == "" || descr_conta == "")
            {
                string textoErro = String.Format("Preencha os campos obrigatórios!");
                throw new ArgumentException(textoErro);
            }

            cdao = new ControleFinanceiro();
            cdao.InserirDados(ong_id, data_mov, descricao, valor, descr_conta, descr_ativo);
        }
        public void AtualizarFinanceiro()
        {
            cdao = new ControleFinanceiro();
            cdao.AtualizarDados(id, ong_id, data_mov, descricao, conta_id, descr_conta, ativo_id, 
                                descr_ativo, valor);
        }
        public void RemoverFinanceiro()
        {
            cdao = new ControleFinanceiro();
            cdao.RemoverDados(id, ong_id, data_mov, descricao, conta_id, descr_conta, ativo_id,
                                descr_ativo, valor);
        }
    }
}

