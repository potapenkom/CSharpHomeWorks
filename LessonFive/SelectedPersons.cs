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

            var adults = from user in users
                         where user.Age > 30
                         orderby user.Age descending
                         orderby user.FirstName
                         select user;

            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }
    }
}
