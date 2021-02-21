using System;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    internal static class Printer
    {
        internal static void PrintBadUserChoiceMessage()
        {
            Console.WriteLine("The input is illegal. Please choose a number in the range of the options given to you.");
        }

        internal static void PrintGoodbyeMessage()
        {
            Console.WriteLine("Thanks for using MenuApp. Bye Bye.");
            Thread.Sleep(2000);
        }

        internal static void PrintTitle(string i_Name)
        {
            Console.Clear();
            Console.WriteLine(string.Format("Menu: {0}", i_Name) + System.Environment.NewLine);
        }

        internal static void PrintAskToChooseOption()
        {
              Console.WriteLine("Choose an option above please");
        }

        internal static void PrintGoBackOption(string i_GoBackMessage)
        {
            Console.WriteLine(string.Format("[0]: {0}." + System.Environment.NewLine, i_GoBackMessage));
        }

        internal static void PrintMenuOption(int i_OptionNumber, string i_ItemName)
        {
            Console.WriteLine(string.Format("[{0}]: {1}" + System.Environment.NewLine, i_OptionNumber, i_ItemName));
        }
    }
}
