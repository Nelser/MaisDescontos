using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Municipio : BaseEntity
    {   
        #region Atributos
        public string EscolhaPais { get; set; }
        public string EscolhaProvincia { get; set; }
        public string Nome { get; set; }
        #endregion
        #region Construtores
        private Municipio(){}
        public Municipio(string escolhaPais, string escolhaProvincia, string nome)
        {
            EscolhaPais = escolhaPais;
            EscolhaProvincia = escolhaProvincia;
            Nome = nome;
            Validar();
        }
        public Municipio(Guid id, string escolhaPais, string escolhaProvincia, string nome): base(id)
        {
            EscolhaPais = escolhaPais;
            EscolhaProvincia = escolhaProvincia;
            Nome = nome;
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