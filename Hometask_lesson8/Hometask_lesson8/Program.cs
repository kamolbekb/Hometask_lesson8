namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your sentences: ");
            string input = Console.ReadLine();
            int countV = 0, countC = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u'))
                {
                    countV++;
                }
                else if (char.IsLetter(input[i]) && (!(input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')))
                {
                    countC++;
                }
                else
                {
                    continue;
                }
            }
            if (countV > countC)
            {
                Console.Write($"There are {countV} vowels in the sentence");
            }
            else
            {
                Console.Write($"There are {countC} consonants in the sentence");
            }
        }
    }
}