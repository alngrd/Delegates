namespace Ex04.Menus.Interfaces
{
   public class MainMenu : Menu
   {
        public MainMenu(string i_Name) : base(i_Name, "Exit") { }

        internal override void GoBack()
        {
            Printer.PrintGoodbyeMessage();
        }
    }
}
