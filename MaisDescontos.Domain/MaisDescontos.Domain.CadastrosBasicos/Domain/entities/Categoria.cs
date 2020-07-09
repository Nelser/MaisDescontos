using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Categoria : BaseEntity
    {
        #region Atributos
        public string Nome { get; set; }
        public string ImagemCategoria { get; set; }
        public bool ApareceHome { get; set; }
        #endregion
        #region Construtores 
        private Categoria() { }
        public Categoria(string nome, string imagemCategoria, bool apareceHome)
        {
            Nome = nome;
            ImagemCategoria = imagemCategoria;
            ApareceHome = apareceHome;
            Validar();
        }
        public Categoria(Guid id, string nome, string imagemCategoria, bool apareceHome): base(id)
        {
            Nome = nome;
            ImagemCategoria = imagemCategoria;
            ApareceHome = apareceHome;
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