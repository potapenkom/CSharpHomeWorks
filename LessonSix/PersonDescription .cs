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
            var PersonDescription = characters.Select(x => new { firstName = x.FirstName,
                                                                 lastName = x.LastName,
                                                                 age =  x.Age,
                                                                 gender =x.Gender });
            foreach (var t in PersonDescription)
                Console.WriteLine($"{t.firstName}, {t.lastName}, {t.age}, {t.gender}");
        }
    }
}
