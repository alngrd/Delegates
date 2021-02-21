using System;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public class EdgeMenuItem : MenuItem
    {
        public event SelectEventHandler m_HandlesTasksWhenSelected;
        private Menu m_ParentMenu;

        public Menu ParentMenu
        {
            get
            {
                return this.m_ParentMenu;
            }
            set
            {
                this.m_ParentMenu = value;
            }
        }      

        public EdgeMenuItem(string i_Name, SelectEventHandler i_SomethingToDo) : base(i_Name) 
        {
            m_HandlesTasksWhenSelected += i_SomethingToDo;
        }

        public void AttachObserver(SelectEventHandler i_ClickObserver)
        {
            m_HandlesTasksWhenSelected += i_ClickObserver;
        }

        public void DetachObserver(SelectEventHandler i_ClickObserver)
        {
            m_HandlesTasksWhenSelected -= i_ClickObserver;
        }

        internal override void OnSelect()
        {
            Console.Clear();
            m_HandlesTasksWhenSelected.Invoke();
            Thread.Sleep(2000);
            this.m_ParentMenu.Show();
        }
    }
}
