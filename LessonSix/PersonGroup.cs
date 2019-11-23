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
            var persons = characters.Where(x => x.Age > 100)
                                    .GroupBy(x => x.Gender);
                                   // .GroupBy(group => { group.Key, group.Count()});
           
            foreach (var person in persons)
            {
                Console.WriteLine($"{person.Key} : {person.Count()}");
               
                Console.WriteLine();
            }
        }
    }
}
