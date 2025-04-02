namespace Classes_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings greetings = new Greetings();   // Create an object of the Greetings class
            greetings.Welcome();     // Call the Welcome method to print a general greeting message

            Console.WriteLine("What is your name?");    // Ask the user to enter their name
            string userName = Console.ReadLine();       // Read the user's input (the name) from the console and store it in the userName variable

            greetings.Hello(userName);   // Call the Hello method, passing the user input (name) to personalize the greeting
        }
    }
}
