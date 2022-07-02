using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SimpleCrud.Person
{
    public interface IPersonAppService
        :ICrudAppService<PersonDto,Guid,PagedAndSortedResultRequestDto,CreateUpdatePersonDto>
    {

    }
}
