using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class BuildMenuWithInterfaces
    {
        private MainMenu m_MainMenu;

        public MainMenu MainMenu
        {
            get
            {
                return this.m_MainMenu;
            }
        }

        public BuildMenuWithInterfaces(string i_Name)
        {
            //Initialize main menu
            this.m_MainMenu = new MainMenu(i_Name);
            
            //Initialize first sub menu and sub items
            EdgeMenuItem countCapitals = new EdgeMenuItem("Count Capitals", new CountCaps());
            EdgeMenuItem showVersion = new EdgeMenuItem("Show Version", new PrintVersion());
            ParentMenuItem versionAndCapitals = new ParentMenuItem("Version And Capitals", this.m_MainMenu);

            //Build first sub menu
            versionAndCapitals.Menu.AddItem(countCapitals);
            versionAndCapitals.Menu.AddItem(showVersion);
            m_MainMenu.AddItem(versionAndCapitals);

            //Initialize second sub menu and sub items
            EdgeMenuItem showTime = new EdgeMenuItem("Show Time", new PrintTime());
            EdgeMenuItem showDate = new EdgeMenuItem("Show Date", new PrintDate());
            ParentMenuItem showDateOrTime = new ParentMenuItem("Show Date/Time", this.m_MainMenu);

            //Build second sub menu
            showDateOrTime.Menu.AddItem(showTime);
            showDateOrTime.Menu.AddItem(showDate);
            this.m_MainMenu.AddItem(showDateOrTime);
        }
    }
}
