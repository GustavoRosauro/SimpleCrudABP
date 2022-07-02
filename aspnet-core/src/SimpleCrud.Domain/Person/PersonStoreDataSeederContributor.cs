using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SimpleCrud.Person
{
    public class PersonStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Person, Guid> _repository;
        public PersonStoreDataSeederContributor(IRepository<Person, Guid> repository)
        {
            _repository = repository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repository.GetCountAsync() <= 0)
            {
                await _repository.InsertAsync(
                new Person
                {
                    Name = "Gustavo Rosauro",
                    Email = "gustavosrosauro@gmail.com",
                    Idade = 30
                },
                autoSave:true
                );
                await _repository.InsertAsync(
                new Person
                {
                    Name = "Amanda Bollmann Medeiros",
                    Email = "amanda.abm@gmail.com",
                    Idade = 26
                },
                autoSave: true
                );
            }
        }
    }
}
