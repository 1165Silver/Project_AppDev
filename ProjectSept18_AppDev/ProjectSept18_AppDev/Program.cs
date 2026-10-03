namespace ProjectSept18_AppDev
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int digits = input.Length - 1;
            string reverse = "";
            for(int i = digits; i >= 0; i--)
            {
                reverse += input[i];
            }

            if(input == reverse)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
