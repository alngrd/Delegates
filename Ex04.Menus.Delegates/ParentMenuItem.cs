namespace Ex04.Menus.Delegates
{
    public class ParentMenuItem : MenuItem
    {
        private Menu m_ChildMenu;

        public ParentMenuItem(string i_Name, Menu i_ParentMenu) : base(i_Name) 
        {
            this.m_ChildMenu = new SubMenu(i_Name , i_ParentMenu);
        }

        public Menu Menu
        {
            get
            {
                return this.m_ChildMenu;
            }
            set
            {
                this.m_ChildMenu = value;
            }
        }

        internal override void OnSelect()
        {
            this.m_ChildMenu.Show();
        }
    }
}
