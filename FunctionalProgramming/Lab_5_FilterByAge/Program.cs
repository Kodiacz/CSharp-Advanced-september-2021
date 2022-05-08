using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_5_FilterByAge
{
    class Person
    {
        public string Name;

        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person();
                person.Name = name;
                person.Age = age;
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());

            Func<Person, bool> filter = p => true;

            if (condition == "older")
            {
                filter = p => p.Age >= conditionAge;
            }
            else if (condition == "younger")
            {
                filter = p => p.Age < conditionAge;
            }
            else if (condition == "exact")
            {
                filter = p => p.Age == conditionAge;
            }

            var filterdPeople = people.Where(filter);

            foreach (var person in filterdPeople)
            {
                Console.WriteLine($"{person.Name} -> {person.Age}");
            }

            string format = Console.ReadLine();

            Func<Person, string> funcFilter = p => $"{p.Name} - {p.Age}";

            if (format == "name age")
            {
                funcFilter = p => $"{p.Name} - {p.Age}";
            }
            else if (format == "name")
            {
                funcFilter = p => $"{p.Name}";
            }
            else if (format == "age")
            {
                funcFilter = p => $"{p.Age}";
            }

            var peopleAsString = filterdPeople.Select(funcFilter);

            foreach (var person in peopleAsString)
            {
                Console.WriteLine(person);
            }
        }
    }
}
