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
            var persons = from character in characters
                          where character.Age > 100
                          group character by character.Gender into ageGroups
                          select new
                          {
                              count = ageGroups.Count(),
                              key = ageGroups.Key
                          };

            foreach (var person in persons)
                       Console.WriteLine($"Count: {person.count}, \tKey: {person.key}");
            var groups = from person in persons
                         select new
                         {
                            groupsItem = person.count,
                            groupsKey = person.key
                         };
            foreach (var group in groups)
                Console.WriteLine($"Count: {group.groupsItem}, \tKey: {group.groupsKey}");
        }
    }
}
