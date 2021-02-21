using System;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    internal static class Printer
    {
        public static void PrintBadUserChoiceMessage()
        {
            Console.WriteLine("The input is illegal. Please choose a number in the range of the options given to you.");
        }

        public static void PrintGoodbyeMessage()
        {
            Console.WriteLine("Thanks for using MenuApp. Bye Bye.");
            Thread.Sleep(2000);
        }

        internal static void PrintAskToChooseOption()
        {
            Console.WriteLine("Choose an option above please");
        }

        public static void PrintTitle(string i_Name)
        {
            Console.Clear();
            Console.WriteLine(string.Format("Menu: {0}" + System.Environment.NewLine, i_Name));
        }

        public static void PrintGoBackOption(string i_GoBackMessage)
        {
            Console.WriteLine(string.Format("[0]: {0}." + System.Environment.NewLine, i_GoBackMessage));
        }

        public static void PrintMenuOption(int i_OptionNumber, string i_ItemName)
        {
            Console.WriteLine(string.Format("[{0}]: {1}" + System.Environment.NewLine, i_OptionNumber, i_ItemName));
        }
    }
}
