using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class ConfigurarSiteAdmin : BaseEntity
    {
        #region Atributos
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Keywords { get; set; }
        public string Logotipo { get; set; }
        public string Favicon { get; set; }
        public string BannerPageInicial { get; set; }
        public string TituloBanner { get; set; }
        public string RedesSociais { get; set; }
        public string InfosFooter { get; set; }
        public string InfosContato { get; set; }
        #endregion
        #region Construtores
        private ConfigurarSiteAdmin(){}
        public ConfigurarSiteAdmin(string titulo,
                                   string descricao,
                                   string keywords,
                                   string logotipo,
                                   string favicon,
                                   string bannerPageInicial,
                                   string tituloBanner,
                                   string redesSociais,
                                   string infosFooter,
                                   string infosContato)
        {
            Titulo = titulo;
            Descricao = descricao;
            Keywords = keywords;
            Logotipo = logotipo;
            Favicon = favicon;
            BannerPageInicial = bannerPageInicial;
            TituloBanner = tituloBanner;
            RedesSociais = redesSociais;
            InfosFooter = infosFooter;
            InfosContato = infosContato;
            Validar();
        }
        public ConfigurarSiteAdmin(Guid id,
                                   string titulo,
                                   string descricao,
                                   string keywords,
                                   string logotipo,
                                   string favicon,
                                   string bannerPageInicial,
                                   string tituloBanner,
                                   string redesSociais,
                                   string infosFooter,
                                   string infosContato): base(id)
        {
            Titulo = titulo;
            Descricao = descricao;
            Keywords = keywords;
            Logotipo = logotipo;
            Favicon = favicon;
            BannerPageInicial = bannerPageInicial;
            TituloBanner = tituloBanner;
            RedesSociais = redesSociais;
            InfosFooter = infosFooter;
            InfosContato = infosContato;
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