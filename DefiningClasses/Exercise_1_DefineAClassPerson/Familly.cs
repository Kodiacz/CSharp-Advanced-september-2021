using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        //public Person GetOldestPerson()
        //{
        //    Person oldestMember = People.OrderByDescending(x => x.Age)
        //        .FirstOrDefault();

        //    return oldestMember;
        //}

        public Person GetOldestPerson(Family family)
        {
            int oldestAge = int.MinValue;
            string oldestName = "";

            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Age > oldestAge)
                {
                    oldestAge = People[i].Age;
                    oldestName = People[i].Name;
                }
            }

            Person oldestGuy = new Person(oldestName, oldestAge);
            return oldestGuy;
        }
    }
}
