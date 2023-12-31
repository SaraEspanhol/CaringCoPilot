﻿using Prototipov1.DAO;
using Prototipov1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prototipov1.VO
{
    internal class CadastroBeneficiariosVO
    {
        private CadastroBeneficiarios cdao;
        private Int32 _pessoa_id;
        String _nome_beneficiario, _rg, _orgao_emissor, _telefone, _email, _data_nasc;

        public CadastroBeneficiariosVO()
        {

        }
        public Int32 pessoa_id
        {
            get { return _pessoa_id; }
            set { _pessoa_id = value; }
        }
        public String nome_beneficiario
        {
            get { return _nome_beneficiario; }
            set { _nome_beneficiario = value; }
        }
        public String rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public String orgao_emissor
        {
            get { return _orgao_emissor; }
            set { _orgao_emissor = value; }
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

        public String data_nasc
        {
            get 
            {
                _data_nasc = Validacoes.ValidaData(_data_nasc);
                return _data_nasc;
            }
            set { _data_nasc = value; }
        }

        public void InserirBeneficiarios()
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
            

            if (nome_beneficiario == "" || rg == "" || orgao_emissor == "")
            {
                string textoErro = String.Format("Preencha os campos obrigatórios!");
                throw new ArgumentException(textoErro);
            }
            cdao = new CadastroBeneficiarios();
            cdao.InserirDadosBeneficiarios(nome_beneficiario, data_nasc, rg, orgao_emissor, telefone, email);
            

        }
        public void AtualizarBeneficiarios()
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


            if (nome_beneficiario == "" || rg == "" || orgao_emissor == "")
            {
                string textoErro = String.Format("Preencha os campos obrigatórios!");
                throw new ArgumentException(textoErro);
            }
            cdao = new CadastroBeneficiarios();
            cdao.AtualizarDadosBeneficiarios(pessoa_id, nome_beneficiario, data_nasc, rg, orgao_emissor, telefone, email);
        }
        public void RemoverBeneficiarios()
        {
            cdao = new CadastroBeneficiarios();
            cdao.RemoverDadosBeneficiarios(pessoa_id, nome_beneficiario, data_nasc, rg, orgao_emissor, telefone, email);
        }
    }
}
