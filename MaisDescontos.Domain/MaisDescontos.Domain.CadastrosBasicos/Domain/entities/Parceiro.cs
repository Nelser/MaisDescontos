using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class Parceiro : BaseEntity
    {
        #region Atributos
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Site { get; set; }
        public string PorcentagemDesconto { get; set; }
        public string CupomParceiro { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool IsRevendedor { get; set; }
        #endregion
        #region Construtores
        private Parceiro(){}
        public Parceiro(string nome,
                        string morada,
                        string bairro,
                        string cidade,
                        string site,
                        string porcentagemDesconto,
                        string cupomParceiro,
                        string email,
                        string senha,
                        bool isRevendedor)
        {
            Nome = nome;
            Morada = morada;
            Bairro = bairro;
            Cidade = cidade;
            Site = site;
            PorcentagemDesconto = porcentagemDesconto;
            CupomParceiro = cupomParceiro;
            Email = email;
            Senha = senha;
            Validar();
        }

        public Parceiro(Guid id,
                        string nome,
                        string morada,
                        string bairro,
                        string cidade,
                        string site,
                        string porcentagemDesconto,
                        string cupomParceiro,
                        string email,
                        string senha,
                        bool isRevendedor): base(id)
        {
            Nome = nome;
            Morada = morada;
            Bairro = bairro;
            Cidade = cidade;
            Site = site;
            PorcentagemDesconto = porcentagemDesconto;
            CupomParceiro = cupomParceiro;
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