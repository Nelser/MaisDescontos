using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Vendedor : BaseEntity
    {
        #region Atributos
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Provincia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        #endregion
        #region Construtores
        private Vendedor(){}
        public Vendedor(string nome,
                        string morada,
                        string provincia,
                        string telefone,
                        string email,
                        string senha)
        {
            Nome = nome;
            Morada = morada;
            Provincia = provincia;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Validar();
        }
        public Vendedor(Guid id,
                        string nome,
                        string morada,
                        string provincia,
                        string telefone,
                        string email,
                        string senha) : base(id)
        {
            Nome = nome;
            Morada = morada;
            Provincia = provincia;
            Telefone = telefone;
            Email = email;
            Senha = senha;
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