
using System;
namespace Core.Models
{

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Cadastro { get; set; } = DateTime.Now;
        public bool Ativo { get; set; }

        //public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}