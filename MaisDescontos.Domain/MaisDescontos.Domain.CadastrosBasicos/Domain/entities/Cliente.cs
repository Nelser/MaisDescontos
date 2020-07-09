using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Cliente : BaseEntity
    {
        #region Atributos
        public string NumeroCartao { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Morada { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DependenteAtivo { get; set; }
        #endregion
        #region Construtores
        private Cliente(){}
        public Cliente(string numeroCartao,
                       string nome,
                       string telefone,
                       string morada,
                       string cidade,
                       string pais,
                       string email,
                       string senha,
                       string dependenteAtivo)
        {
            NumeroCartao = numeroCartao;
            Nome = nome;
            Telefone = telefone;
            Morada = morada;
            Cidade = cidade;
            Pais = pais;
            Email = email;
            Senha = senha;
            DependenteAtivo = dependenteAtivo;
            Validar();
        }
        public Cliente(Guid id,
                       string nome,
                       string telefone,
                       string morada,
                       string cidade,
                       string pais,
                       string email,
                       string senha,
                       string dependenteAtivo): base(id)
        {
            Nome = nome;
            Telefone = telefone;
            Morada = morada;
            Cidade = cidade;
            Pais = pais;
            Email = email;
            Senha = senha;
            DependenteAtivo = dependenteAtivo;
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