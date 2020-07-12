using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Assinatura : BaseEntity
    {
        #region Atributos
        public string Valor { get; set; }
        public string TipoAssinatura { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        #endregion
        #region Construtores
        private Assinatura(){}
        public Assinatura(string valor, string tipoAssinatura, DateTime fim)
        {
            Valor = valor;
            TipoAssinatura = tipoAssinatura;
            DataInicio = DateTime.Now;
            DataFim = fim;
            Validar();
        }
        public Assinatura(Guid id, string valor, string tipoAssinatura): base(id)
        {
            Valor = valor;
            TipoAssinatura = tipoAssinatura;
            Validar();
        }
        #endregion
        #region Metodos
        protected override void Validar()
        {

        }
        #endregion
    }
}