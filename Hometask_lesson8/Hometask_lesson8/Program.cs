namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your full name: ");
            string fullName = Console.ReadLine();
            string[] array = fullName.Split(' ');
            string initials = "";
            foreach (string output in array)
            {
                initials += output.Substring(0, 1).ToUpper() + '.';
            }
            Console.Write("Result: " + initials);
        }
    }
}