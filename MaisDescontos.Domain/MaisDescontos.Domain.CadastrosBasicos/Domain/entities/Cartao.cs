using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Cartao : BaseEntity
    {
        #region Atributos
        public string NomeProprietario { get; set; }
        public string Numero { get; set; }
        public string DataValidade { get; set; }
        public bool Ativo { get; set; }
        #endregion
        #region Construtores
        private Cartao(){}
        public Cartao(string nomeProprietario, string numero, string dataValidade, bool ativo)
        {
            NomeProprietario = nomeProprietario;
            Numero = numero;
            DataValidade = dataValidade;
            Ativo = ativo;
            Validar();
        }
        public Cartao(Guid id, string nomeProprietario, string numero, string dataValidade, bool ativo): base(id)
        {
            NomeProprietario = nomeProprietario;
            Numero = numero;
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