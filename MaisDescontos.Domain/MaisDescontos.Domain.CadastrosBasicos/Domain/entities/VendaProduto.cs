using System;
using MaisDescontos.Domain.Core.Entities;

namespace MaisDescontos.Domain.CadastrosBasicos.Domain.entities
{
    public class VendaProduto : BaseEntity
    {
        public string NumeroCartaoCliente { get; set; }
        public string SelecaoProduto { get; set; }
        public string Valor { get; set; }
        public string Cupom { get; set; }
        public string ValorPago { get; set; }
        public string Observação { get; set; }
        public string DataCompra { get; set; }
        public string FotoCliente { get; set; }
        public VendaProduto(){}
        public VendaProduto(string numeroCartaoCliente,
                            string selecaoProduto,
                            string valor,
                            string cupom,
                            string valorPago,
                            string dataCompra,
                            string fotoCliente)
        {
            NumeroCartaoCliente = numeroCartaoCliente;
            SelecaoProduto = selecaoProduto;
            Valor = valor;
            Cupom = cupom;
            ValorPago = valorPago;
            DataCompra = dataCompra;
            FotoCliente = fotoCliente;

        }
        public VendaProduto(Guid id,
                            string selecaoProduto,
                            string valor,
                            string cupom,
                            string valorPago): base(id)
        {
            SelecaoProduto = selecaoProduto;
            Valor = valor;
            Cupom = cupom;
            ValorPago = valorPago;
        }
        protected override void Validar()
        {

        }
    }
}