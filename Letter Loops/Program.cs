using System;

namespace Letter_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter strings like abcd");
            var letters = Console.ReadLine();
            var counter = 1;
            string newString = "";

            foreach (var letter in letters)
            {
                for (var i = 0; i < counter; i++)
                {
                    newString += letter;
                }
                newString += "-";
                counter++;
            }
            Console.WriteLine(newString.TrimEnd('-'));
        }
    }
}
