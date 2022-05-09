using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();
            Family olderThanThirty = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddPerson(person);
            }

            for (int i = 0; i < family.People.Count; i++)
            {
                if (family.People[i].Age > 30)
                {
                    olderThanThirty.AddPerson(family.People[i]);
                }
            }

            olderThanThirty.People = olderThanThirty.People.OrderBy(x => x.Name).ToList();

            foreach (var person in olderThanThirty.People)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
