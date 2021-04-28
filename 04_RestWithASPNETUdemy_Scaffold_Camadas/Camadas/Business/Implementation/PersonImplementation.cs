using Camadas.Model;
using Camadas.Model.Context;
using Camadas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camadas.Business.Implementation
{
    public class PersonImplementation : PersonBusiness
    {
        private readonly PersonRepository _repository;

        public PersonImplementation(PersonRepository repository)
        {
            _repository = repository;
        }
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
