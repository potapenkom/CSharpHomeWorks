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
            var persons = characters.Where(x => x.Age > 10)
                                    .GroupBy(x => x.Gender)
                                    .GroupBy(group =>  group.Count())
                                    .Select(person => new {
                                         firstName = person.Key,
                                         lastName = person.Key,
                                         age = person.Key,
                                         gender = person.Key
                                     });
            foreach (var person in persons)
            foreach (var group in person)
            foreach(var g in group)
                    Console.WriteLine( g.firstName, g.lastName, g.gender, g.age);
        }
    }
}
