using System;

namespace P02.RandomizeWords
{
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] text = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                int index = rnd.Next(0, text.Length);
                string rem = text[index];
                int newIndex = rnd.Next(0, text.Length);
                text[index] = text[newIndex];
                text[newIndex] = rem;
            }

            for (int j = 0; j < text.Length; j++)
            {
                Console.WriteLine(text[j]);
            }
        }
    }
}
