using System;
using LessonFive.HelpMaterial;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LessonSix
{
   public static class PersonDescription
   {
        public static void ShowProperty()
        {
            var characters = PersonsService.GetPersons();
            var PersonDescription = characters.Select(x => new { x.FirstName,x.LastName, x.Age, x.Gender });
            foreach (var person in PersonDescription)
                Console.WriteLine(person.FirstName, person.LastName, person.Age, person.Gender);
        }
    }
}
