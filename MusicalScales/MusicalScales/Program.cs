using System;
using System.Collections.Generic;

namespace MusicalScales
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scales = { "a", "a#", "b", "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#", "a", "a#", "b", "c", "c#", "d", "d#", "e", "f", "f#", "g", "g#"};
            Console.WriteLine("Please enter your major scale: ");
            int userScale = Array.IndexOf(scales, Console.ReadLine());


            string[] solfegeFinder = { scales[userScale], scales[userScale += 2], scales[userScale += 2], scales[userScale += 1], scales[userScale += 2], scales[userScale += 2], scales[userScale += 2] };


            Console.Write("The notes in your scale are: ");
            foreach (string note in solfegeFinder)
            {
                Console.Write(note + ", ");
            }
            
            Console.Write("\n\nPlease enter the solfege name of your note: ");

            string[] solfege = { "do", "re", "mi", "fa", "so", "la", "ti" };

            int solfegeIndex = Array.IndexOf(solfege, Console.ReadLine());

            Console.WriteLine("The note you are looking for is: " + solfegeFinder[solfegeIndex]);
            Console.ReadKey();

        }
    }
}
