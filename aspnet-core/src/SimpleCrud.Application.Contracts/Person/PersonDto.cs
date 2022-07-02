using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SimpleCrud.Person
{
    public class PersonDto:AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
    }
}
