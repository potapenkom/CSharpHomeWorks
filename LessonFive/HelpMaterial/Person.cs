﻿namespace LessonFive.HelpMaterial
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, bool gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, \tLastnName: {LastName}, \tGender: {Gender}, \tAge: {Age}";
        }
    }
}
