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
    }
}

