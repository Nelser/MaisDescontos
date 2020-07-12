namespace MaisDescontos.Domain.Core.Domain.ValueObjects
{
    public class NumeroCartaoValueObject : BaseValueObject
    {
        public string Numero { get; set; }

        protected override void Validar()
        {
            
        }
    }
}