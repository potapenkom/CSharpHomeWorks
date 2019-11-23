using System;
using System.Collections.Generic;
using System.Text;

namespace LessonFive
{
   public static class HumanExtension
    {
       public static void Evolve(this Human Ext)
        {
            Ext.MostImportantBodyPart = BodyParts.Arms;
        }
    }
}
