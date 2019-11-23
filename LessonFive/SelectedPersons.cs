using System;
using System.Collections.Generic;
using System.Linq;
using LessonFive.HelpMaterial;

namespace LessonFive
{
    public static class SelectedPersons
    {
        public static void ShowExtensionMethodSyntax()
        {
            var users = PersonsService.GetPersons();

            var adults = users.Where(n => n.Age > 30).OrderByDescending(x => x.Age).ThenBy(x => x.FirstName); ;
            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }
    }
}
