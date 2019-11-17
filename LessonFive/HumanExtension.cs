using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFive
{
   public static class HumanExtension
    {
       public static BodyParts Evolve(this Human Ext)
        {
            return Ext.MostImportantBodyPart = BodyParts.Arms;
        }
    }
}
