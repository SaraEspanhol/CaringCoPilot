using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototipov1
{
    class PlanoDeContasVO
    {
       
        private PlanoDeContas cdao;
        private int _id;
        private string _tipo_conta;
        private string _descr_conta;
        private int _idAtivos;
        private string _descr_ativo;


        public PlanoDeContasVO()
        {

        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string tipo_conta
        {
            get { return _tipo_conta; }
            set { _tipo_conta = value; }
        }
        public string descr_conta
        {
            get { return _descr_conta; }
            set { _descr_conta = value; }
        }

        public int idAtivos
        {
            get { return _idAtivos; }
            set { _idAtivos = value; }
        }

        public string descr_ativo
        {
            get { return _descr_ativo; }
            set { _descr_ativo = value; }
        }

        // CONTAS //
        public void Inserir()
        {
            cdao = new PlanoDeContas();
            cdao.InserirDados(tipo_conta, descr_conta);
        }
        public void Atualizar()
        {
            cdao = new PlanoDeContas();
            cdao.AtualizarDados(tipo_conta, descr_conta, id);
        }
        public void Remover()
        {
            cdao = new PlanoDeContas();
            cdao.RemoverDados(tipo_conta, id);
        }

        // ATIVOS //
        public void InserirAtivos()
        {
            cdao = new PlanoDeContas();
            cdao.InserirDadosAtivos(descr_ativo);
        }
        public void AtualizarAtivos()
        {
            cdao = new PlanoDeContas();
            cdao.AtualizarDadosAtivos(idAtivos, descr_ativo);
        }
        public void RemoverAtivos()
        {
            cdao = new PlanoDeContas();
            cdao.RemoverDadosAtivos(idAtivos, descr_ativo);
        }
    }
}

