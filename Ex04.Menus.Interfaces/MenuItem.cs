namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Name;

        public MenuItem(string i_Name)
        {
            this.m_Name = i_Name;
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

        internal abstract void OnSelect();
    }
}
