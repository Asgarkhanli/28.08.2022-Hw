using System;
using System.IO;

namespace _28._08._2022_Hw
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            //Task_01

            string fileName = @"mytest.txt";
            string[] ArrLines;
            int n, i;
            Console.Write("\n\n Create and read the last line of a file :\n");
            Console.Write("----------------------------------------------\n");

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write("Input number of lines to write in the file :");
            n = Int32.Parse(Console.ReadLine());
            ArrLines = new string[n];
            Console.Write("Input {0} strings below :\n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("Input line {0} : ", i + 1);
                ArrLines[i] = Console.ReadLine();
            }
            System.IO.File.AppendAllLines(fileName, ArrLines);
            Console.Write("\n The contentn of the last line of the file {0} is :\n", fileName);
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                Console.WriteLine(" {0}", lines[n - 1]);
            }
            Console.WriteLine();
        }
    }
}
