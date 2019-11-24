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
            var groups = from person in characters
                         where person.Age > 100
                         group person by person.Gender into genderGroups
                         group genderGroups by genderGroups.Count() into countedGroup
                         select new
                         {
                             Key = countedGroup.Key,
                             Count = countedGroup.Count(),
                             Group = countedGroup
                         };

            foreach (var persons in groups)
                foreach (var person in persons.Group)
                    foreach (var human in person)
                    {
                        Console.WriteLine(human);
                    }
        }
    }
}

