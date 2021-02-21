using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Delegates
{
    public abstract class Menu
    {
        private List<MenuItem> m_ItemsInMenu;
        private string m_Name;
        private readonly string r_GoBackMessage;

        public Menu(string i_Name, string i_GoBackMessage)
        {
            this.m_ItemsInMenu = new List<MenuItem>();
            this.m_Name = i_Name;
            this.r_GoBackMessage = i_GoBackMessage;
        }

        public string Name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }

        /*
      * Goes back to previous menu or exit if from main menu
      */
        internal abstract void GoBack();

        public void AddItem(MenuItem i_ItemToAdd)
        {
            this.m_ItemsInMenu.Add(i_ItemToAdd);
            if (i_ItemToAdd is EdgeMenuItem)
            {
                (i_ItemToAdd as EdgeMenuItem).ParentMenu = this;
            }
        }

        public void RemoveItem(MenuItem i_ItemToRemove)
        {
            this.m_ItemsInMenu.Remove(i_ItemToRemove);
        }

        public void Show()
        {
            int i = 1;
            int userChoise = 0;

            Printer.PrintTitle(this.m_Name); 
            foreach (MenuItem item in this.m_ItemsInMenu)
            {
                Printer.PrintMenuOption(i, item.Name);
                i++;
            }

            Printer.PrintGoBackOption(this.r_GoBackMessage);
            Printer.PrintAskToChooseOption();
            userChoise = getUserChoice();
            implementUserChoice(userChoise);
        }

        private int getUserChoice()
        {
            int userChoice = 0;

            while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 0 || userChoice > this.m_ItemsInMenu.Count)
            {
                Printer.PrintBadUserChoiceMessage();
            }

            return userChoice;
        }

        private void implementUserChoice(int i_UserChoice)
        {
            if (i_UserChoice == 0)
            {
                this.GoBack();
            }
            else
            {
                this.m_ItemsInMenu.ElementAt(i_UserChoice - 1).OnSelect();
            }
        }
    }
}