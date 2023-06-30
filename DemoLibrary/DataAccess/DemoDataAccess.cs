using System;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();
        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel { Id = 2, FirstName = "Sue", LastName = "Storm" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPeople(string firstName, string lastName)
        {
            PersonModel model = new() { FirstName = firstName, LastName = lastName };
            model.Id = people.Max(x => x.Id) + 1;
            people.Add(model);
            return model;
        }
    }
}

