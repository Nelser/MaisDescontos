using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Cidade : BaseEntity
    {
        #region Atributos
        public string Nome { get; set; }
        #endregion
        #region Construtores
        private Cidade(){}
        public Cidade(string nome)
        {
            Nome = nome;
            Validar();
        }

        public Cidade(Guid id, string nome): base(id)
        {
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