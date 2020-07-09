using Flunt.Validations;

namespace MaisDescontos.Domain.Core.Domain.ValueObjects
{
    public class NomeValueObject : BaseValueObject
    {
        public string Nome { get; set;  }
        
        public NomeValueObject(){}
        public NomeValueObject(string nome)
        {
            Nome = nome;
            Validar();
        }
        protected override void Validar()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Nome, 5, "Nome", "O Campo \"Nome\" deve ter no mínimo 5 caracteres")
                .HasMaxLen(Nome, 120, "Nome", "O Campo \"Nome\" deve ter no máximo 120 caracteres")
            );
        }
    }
}