using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEleventhSol
{
    public static class WriteTextClass
    {
        public static void WriteText()
        {
            string writePath = @"C:\Projects\some.txt";
            string text = "Привет мир!\nПока мир...";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
                {
                     sw.WriteLineAsync(text);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
