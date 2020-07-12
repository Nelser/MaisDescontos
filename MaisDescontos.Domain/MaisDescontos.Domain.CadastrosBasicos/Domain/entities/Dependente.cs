using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Dependente : BaseEntity
    {
        #region Atributos
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public string Foto { get; set; }
        public string Provincia { get; set; }
        public string NomeProprietarioCartao { get; set; }
        public string GrauParentesco { get; set; }
        #endregion
        #region Construtores
        private Dependente(){}
        public Dependente(string nome,
                           string telefone,
                           int idade,
                           string foto,
                           string provincia,
                           string nomeProprietarioCartao,
                           string grauParentesco)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Foto = foto;
            Provincia = provincia;
            NomeProprietarioCartao = nomeProprietarioCartao;
            GrauParentesco = grauParentesco;
            Validar();
        }
        public Dependente(Guid id,
                           string nome,
                           string telefone,
                           int idade,
                           string foto,
                           string provincia,
                           string nomeProprietarioCartao,
                           string grauParentesco) : base(id)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Foto = foto;
            Provincia = provincia;
            NomeProprietarioCartao = nomeProprietarioCartao;
            GrauParentesco = grauParentesco;
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