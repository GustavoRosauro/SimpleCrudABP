using AutoMapper;
using SimpleCrud.Person;

namespace SimpleCrud;

public class SimpleCrudApplicationAutoMapperProfile : Profile
{
    public SimpleCrudApplicationAutoMapperProfile()
    {
        CreateMap<Person.Person, PersonDto>();
        CreateMap<CreateUpdatePersonDto, Person.Person>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
