using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFive
{
   public enum BodyParts
    {
        Head, Legs, Arms
    }

  public class Human
    {
        public BodyParts MostImportantBodyPart = BodyParts.Head;
    }
}
