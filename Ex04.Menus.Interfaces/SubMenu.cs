namespace Ex04.Menus.Interfaces
{
    internal class SubMenu : Menu
    {
        private Menu m_PreviousMenu;

        public SubMenu(string i_Name, Menu i_PreviousMenu) : base(i_Name, "Go back")
        {
            this.m_PreviousMenu = i_PreviousMenu;
        }

        public Menu PreviousMenu
        {
            get
            {
                return this.m_PreviousMenu;
            }
            set
            {
                this.m_PreviousMenu = value;
            }
        }

        internal override void GoBack()
        {
            this.m_PreviousMenu.Show();
        }
    }
}
