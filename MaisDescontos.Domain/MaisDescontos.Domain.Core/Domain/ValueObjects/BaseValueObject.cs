using Flunt.Notifications;

namespace MaisDescontos.Domain.Core.Domain.ValueObjects
{
    [System.ComponentModel.DataAnnotations.Schema.NotMapped]
    public abstract class BaseValueObject : Notifiable
    {
        protected abstract void Validar(); 
    }
}