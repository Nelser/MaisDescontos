using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace MaisDescontos.Domain.Core.Entities
{
    public abstract class BaseEntity : Notifiable 
    {
        public Guid Id { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            
        }

        public BaseEntity(Guid id)
        {
            Id = id;
            ValidarId();
        }
        public void ValidarId()
        {
            AddNotifications(new Contract()
                .Requires()
                .AreNotEquals(Guid.Empty, Id, "Id", "Informe um id válido")
            );
        }

        protected abstract void Validar();
    }
}