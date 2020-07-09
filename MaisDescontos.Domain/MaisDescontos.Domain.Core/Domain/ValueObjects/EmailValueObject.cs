using Flunt.Validations;

namespace MaisDescontos.Domain.Core.Domain.ValueObjects
{
    public class EmailValueObject : BaseValueObject
    {
        public string Email { get; set; }

        public EmailValueObject(){}

        public EmailValueObject(string email)
        {
            Email = email;
            Validar();
        }
        protected override void Validar()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Email, "Email", "O Campo \"Email\" é inválido")
            );
        }
    }
}