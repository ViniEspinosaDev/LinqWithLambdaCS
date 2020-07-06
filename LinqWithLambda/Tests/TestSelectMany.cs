using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqWithLambda.Tests
{
    public class TestSelectMany : ITest
    {
        public void Test()
        {
            var persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Name = "John",
                PersonPhones = new List<PersonPhone>() {
                    new PersonPhone { PhoneNumber = "15997826699"},
                    new PersonPhone { PhoneNumber = "1533224455"}
                }
            });

            persons.Add(new Person
            {
                Id = 2,
                Name = "Mary",
                PersonPhones = new List<PersonPhone>() {
                    new PersonPhone { PhoneNumber = "15997211299"},
                    new PersonPhone { PhoneNumber = "1533224466"}
                }
            });

            // Quero pegar todos os números de telefone, independente da pessoa...

            var phones = persons.SelectMany(person => person.PersonPhones);

            foreach (var phone in phones)
            {
                Console.WriteLine("Phone: " + phone.PhoneNumber);
            }

        }

        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<PersonPhone> PersonPhones { get; set; }
        }

        class PersonPhone
        {
            public string PhoneNumber { get; set; }
        }
    }
}
