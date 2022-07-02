using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SimpleCrud.Person
{
    public class Person:AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}
