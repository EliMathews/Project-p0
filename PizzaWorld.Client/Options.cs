using System;

namespace PizzaWorld.Client
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
        public static string UserChoiceObj { get; set; }
        public static string UserChoice()
        {
            string UserChoiceObj = Console.ReadLine();
            return UserChoiceObj;
        } 
         public static void StoreSelectionPrompt()
         {
             string Prompt1 = "Please select a store to access from the list displayed below.";
             string Prompt2 = "To select a store, enter its name.";
            System.Console.WriteLine(Prompt1);
            System.Console.WriteLine(Prompt2);
         }

    }
}