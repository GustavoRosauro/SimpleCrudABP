using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SimpleCrud.Person
{
    public class PersonAppService : CrudAppService<Person, PersonDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePersonDto>,
        IPersonAppService
    {
        public PersonAppService(IRepository<Person, Guid> repository) : base(repository)
        {
        }
    }
}
