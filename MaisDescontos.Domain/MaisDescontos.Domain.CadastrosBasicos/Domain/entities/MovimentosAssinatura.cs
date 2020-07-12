using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class MovimentosAssinatura : BaseEntity
    {
        #region Atributos
        public string MetaAtivacao { get; set; }
        public string ValorPoupadoClientes { get; set; }
        public string FamiliaresNoMes { get; set; }
        public string IndividuaisNoMes { get; set; }
        public string CartoesParaRenovar { get; set; }
        public string CriadosRenovadosNoMes { get; set; }
        public string CartoesAtivos { get; set; }
        public string UltimosParceiros { get; set; }
        public string UltimosCartoesAtivos { get; set; }
        public string UltimosCartoesRenovados { get; set; }
        #endregion
        #region Construtores
        public MovimentosAssinatura(){}
        public MovimentosAssinatura(string metaAtivacao,
                                    string valorPoupadoClientes,
                                    string familiaresNoMes,
                                    string individuaisNoMes,
                                    string cartoesParaRenovar,
                                    string criadosRenovadosNoMes,
                                    string cartoesAtivos)
        {
            MetaAtivacao = metaAtivacao;
            ValorPoupadoClientes = valorPoupadoClientes;
            FamiliaresNoMes = familiaresNoMes;
            IndividuaisNoMes = individuaisNoMes;
            CartoesParaRenovar = cartoesParaRenovar;
            CriadosRenovadosNoMes = criadosRenovadosNoMes;
            CartoesAtivos = cartoesAtivos;
            Validar();
        }
        public MovimentosAssinatura(Guid id,
                                    string metaAtivacao): base(id)
        {
            MetaAtivacao = metaAtivacao;
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