using System;
using System.IO;

namespace ReadingLinesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"‪C:\Users\Dillon\Downloads\Pride and Prejudice by Jane Austen.txt";

            //string entireBook = File.ReadAllText(filePath);
            string[] allLines = File.ReadAllLines(filePath);

            /*Output 5 lines at a time
            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(allLines[i]);
            }
            */

            //output a chapter at a time
            foreach (var lines in allLines)
            {
                if (lines.ToLower().Contains("Chapter") == true) 
                {
                    Console.ReadKey();
                }
                Console.WriteLine(lines);
            }
            Console.WriteLine(allLines);
        }
    }
}
