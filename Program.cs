using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Упражнение_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter f1 = new StreamWriter("D:\\f1.txt");
            Random r = new Random();
            for (int i = 0; i < 10; i++) f1.WriteLine(r.Next(0, 100));
            f1.Close();
            StreamReader fr = new StreamReader("D:\\f1.txt");
            string[] strNumbers = System.IO.File.ReadAllLines(@"D:\\f1.txt");
            int count = 0;
            foreach (string strNumber in strNumbers)
            {
                if (Int32.TryParse(strNumber, out int number))
                {
                    count = count + number;
                }
            }
            Console.WriteLine("Total : " + count);

            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
