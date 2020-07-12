using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Provincia : BaseEntity
    {
        #region Atributos
        public string EscolhaPais { get; set; }
        public string Nome { get; set; }
        #endregion
        #region Construtores
        private Provincia(){}
        public Provincia(string escolhaPais, string nome)
        {
            EscolhaPais = escolhaPais;
            Nome = nome;
            Validar();
        }
        public Provincia(Guid id, string escolhaPais, string nome): base(id)
        {
            EscolhaPais = escolhaPais;
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