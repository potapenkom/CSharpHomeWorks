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
            var PersonDescription = from character in characters
                                    select new
                                    {
                                        firstName = character.FirstName,
                                        lastName= character.LastName,
                                        age = character.Age,
                                        gender = character.Gender
                                    };
            foreach (var t in PersonDescription)
                Console.WriteLine($"\t{t.firstName}, \t{t.lastName}, \t{t.age}, \t{t.gender}");
        }
    }
}
