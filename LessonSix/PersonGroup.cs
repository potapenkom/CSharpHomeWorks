using System;
using System.Collections.Generic;
using LessonFive.HelpMaterial;
using System.Linq;
using System.Text;

namespace LessonSix
{
    public static class PersonGroup
    {
        public static void ShowGroup()
        {
            var characters = PersonsService.GetPersons();

            var groups = from character in characters
                         where character.Age > 100
                         group character by character.Gender into g
                               select new
                               {
                                   Name = g.Key,
                                   Count = g.Count(),
                                   Person = from p in g select p
                               };
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Name} : {group.Count}");
                foreach (var person in group.Person)
                    Console.WriteLine(person.Gender);
                Console.WriteLine();
            }
        }
    }
}
