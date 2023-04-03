namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Registration Program");
            UserValidation.ValidateFirstName();
            Console.ReadLine();
        }
    }
}