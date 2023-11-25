using Prototipov1.DAO;
using Prototipov1.Helpers;
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
            get
            {
                _data_nasc = Validacoes.ValidaData(_data_nasc);
                return _data_nasc;
            }
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
            bool v;

            v = Validacoes.IsValidEmail(email);
            if (!(v))
            {
                string textoErro = String.Format("Insira um e-mail válido!");
                throw new ArgumentException(textoErro);
            }

            v = Validacoes.IsValidTelefone(telefone);
            if (!(v))
            {
                string textoErro = String.Format("Insira um telefone válido!");
                throw new ArgumentException(textoErro);
            }

            if (nome == "" || documento == "")
            {
                string textoErro = String.Format("Preencha os campos obrigatórios!");
                throw new ArgumentException(textoErro);
            }

            if (tipo_doador != "Pessoa Física" || tipo_doador != "Pessoa Jurídica")
            {
                string textoErro = String.Format("Insira um Tipo de Doador Válido!");
                throw new ArgumentException(textoErro);
            }

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
