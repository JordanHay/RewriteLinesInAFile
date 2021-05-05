using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AlgorithmsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> primaryLines = File.ReadAllLines(@"primary.txt").ToList();


            Console.Write("Please give me the text to replace: ");
            string toReplace = Console.ReadLine();

            Console.Write("Please give me the replacement text: ");
            string replacementText = Console.ReadLine();

            for (int i = 0; i < primaryLines.Count; i++)
            {
                primaryLines[i] = primaryLines[i].Replace(toReplace, replacementText);
            }

            File.WriteAllLines(@"primary.txt", primaryLines);

            Console.WriteLine("The text file has been updated.");

            Console.ReadLine();

        }

    }

}



