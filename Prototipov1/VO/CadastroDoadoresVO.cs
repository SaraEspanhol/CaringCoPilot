using Prototipov1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1.VO
{
    internal class CadastroDoadoresVO
    {
        private CadastroDoadores cdao;
        private Int32 _id;
        String  _tipo_doador, _documento, _nome, _data_nasc, _telefone, _email;

        public CadastroDoadoresVO()
        {

        }

        public Int32 id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String tipo_doador
        {
            get { return _tipo_doador; }
            set { _tipo_doador = value; }
        }

        public String documento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String data_nasc
        {
            get { return _data_nasc; }
            set { _data_nasc = value; }
        }

        public String telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public String email
        {
            get { return _email; }
            set { _email = value; }
        }

        public void InserirDoadores()
        {
            cdao = new CadastroDoadores();
            cdao.InserirDadosDoadores(tipo_doador,  documento,  nome, data_nasc, email, telefone);
        }
        public void AtualizarDoadores()
        {
            cdao = new CadastroDoadores();
            cdao.AtualizarDadosDoadores(id, tipo_doador, documento, nome, data_nasc, email, telefone);
        }
        public void RemoverDoadores()
        {
            cdao = new CadastroDoadores();
            cdao.RemoverDadosDoadores(id, tipo_doador, documento, nome, data_nasc, email, telefone);
        }

    }
}
