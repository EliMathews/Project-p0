using System;

namespace PizzaWorld.Domain.Models
{
    public class Options
    {
        public static void CustomerOrStorePrompt()
        {
            string Prompt = "Would you like to access the application as a customer or a store?";
            string Prompt2 = "Enter customer or store:";
            System.Console.WriteLine(Prompt);
            System.Console.WriteLine(Prompt2);
            //System.Console.WriteLine(user);

        }

        public static string UserChoice()
        {
            string UserChoice = Console.ReadLine();
            return UserChoice;
        }
        
    }
}
