namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter your full name: ");
            //string fullName = Console.ReadLine();
            //string[] array = fullName.Split(' ');
            //string initials = "";
            //foreach (string output in array)
            //{
            //    initials += output.Substring(0, 1).ToUpper() + '.';
            //}
            //Console.Write("Result: " + initials);

            Console.Write("Please enter your sentences: ");
            string longestWord = Console.ReadLine();
            string[] input = longestWord.Split(" ");
            string result = "";
            int count = 0;
            foreach (string str in input)
            {
                if (str.Length > count)
                {
                    result = str;
                    count = str.Length;
                }
            }
            Console.Write(result);

        }
    }
}