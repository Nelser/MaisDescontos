using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class ReativacaoCartao : BaseEntity
    {
        #region Atributos
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Morada { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string DataVenda { get; set; }
        public string RenovacaoCartao { get; set; }
        public string CodigoProprietarioCliente { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string EscolhaModelo { get; set; }
        #endregion
        #region Construtores
        private ReativacaoCartao(){}
        public ReativacaoCartao(string nome,
                                string telefone,
                                string morada,
                                string provincia,
                                string pais,
                                string dataVenda,
                                string email,
                                string senha,
                                string escolhaModelo)
        {
            Nome = nome;
            Telefone = telefone;
            Morada = morada;
            Provincia = provincia;
            Pais = pais;
            DataVenda = dataVenda;
            Email = email;
            Senha = senha;
            EscolhaModelo = escolhaModelo;
            Validar();
        }
        public ReativacaoCartao(Guid id,
                                string nome,
                                string telefone,
                                string morada,
                                string provincia,
                                string pais,
                                string email,
                                string senha,
                                string escolhaModelo):base(id)
        {
            Nome = nome;
            Telefone = telefone;
            Morada = morada;
            Provincia = provincia;
            Pais = pais;
            Email = email;
            Senha = senha;
            EscolhaModelo = escolhaModelo;
            Validar();
        }
        #endregion
        #region Métodos
        protected override void Validar()
        {

        }
        #endregion
    }
}