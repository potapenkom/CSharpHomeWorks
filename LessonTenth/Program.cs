using System;

namespace LessonTenth
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileInfoExample.ShowFileInfo();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
