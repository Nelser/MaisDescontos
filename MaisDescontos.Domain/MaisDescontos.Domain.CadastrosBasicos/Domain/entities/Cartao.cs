using System;
using MaisDescontos.Domain.Core.Domain.ValueObjects;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Cartao : BaseEntity
    {
        #region Atributos
        public string NomeProprietario { get; set; }
        public NumeroCartaoValueObject _numero { get; set; }
        public string Numero { get{return _numero.Numero;} set{;} }
        public string DataValidade { get; set; }
        public bool Ativo { get; set; }
        #endregion
        #region Construtores
        private Cartao(){}
        public Cartao(string nomeProprietario, string dataValidade, bool ativo)
        {
            NomeProprietario = nomeProprietario;
            DataValidade = dataValidade;
            Ativo = ativo;
            Validar();
        }
        public Cartao(Guid id, string nomeProprietario, string dataValidade, bool ativo): base(id)
        {
            NomeProprietario = nomeProprietario;
            DataValidade = dataValidade;
            Ativo = ativo;
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