using Flunt.Validations;

namespace MaisDescontos.Domain.Core.Domain.ValueObjects
{
    public class SenhaValueObject : BaseValueObject
    {
        public string Senha { get; set; }

        public SenhaValueObject(){}
        public SenhaValueObject(string senha)
        {
            Senha = senha;
            Validar();
        }
        protected override void Validar()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Senha, 8, "Senha", "O Campo \"Senha\" deve conter no mínimo 8 caracteres")
            );
        }
    }
}