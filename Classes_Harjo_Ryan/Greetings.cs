using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Harjo_Ryan
{
    internal class Greetings
    {
        public void Welcome()    // This method prints a welcome message to the user
        {
            Console.WriteLine("Hello User, Welcome!");    // Output a general welcome message to the console
        }
        public void Hello(string name)    // This method accepts a string parameter 'name' and prints a personalized message
        {
            Console.WriteLine($"{name}, thank you for joining us today!");  // Output a personalized thank you message with the provided name
        }
    }
}
