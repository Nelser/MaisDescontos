using System;
using MaisDescontos.Domain.Core.Domain.ValueObjects;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.entities
{
    public class Administrador : BaseEntity
    {
        #region ValueObjects
        public NomeValueObject _nome { get; set; }
        public EmailValueObject _email { get; set; }
        public SenhaValueObject _senha { set; get; }
        #endregion
        #region Atributos
        public string Nome { get{return _nome.Nome;} set{} }
        public string Utilizador { get; set; }
        public string Email { get{return _email.Email;} set{} }
        public string Senha { get{return _senha.Senha;} set{} }
        #endregion
        #region Construtores
        private Administrador(){}

        public Administrador(string nome, string utilizador, string email, string senha)
        {
            Nome = nome;
            Utilizador = utilizador;
            Email = email;
            Senha = senha;
            Validar();
        }
        public Administrador(Guid id, string nome, string utilizador, string email, string senha):base(id)
        {
            Nome = nome;
            Utilizador = utilizador;
            Email = email;
            Senha = senha;
            Validar();
        }
        #endregion
        #region Metodos
        protected override void Validar()
        {
            AddNotifications(_nome);
            AddNotifications(_email);
            AddNotifications(_senha);
        }
        #endregion
    }
}