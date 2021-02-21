using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
    public interface IClickObserver
    {
        void ReportClicked();
    }

    public class EdgeMenuItem : MenuItem
    {
        private List<IClickObserver> m_NotifyWhenClicked;
        private Menu m_ParentMenu;

        public EdgeMenuItem(string i_Name, IClickObserver i_ClickListener) : base(i_Name)
        {
            this.m_NotifyWhenClicked = new List<IClickObserver>();
            this.m_NotifyWhenClicked.Add(i_ClickListener);
        }

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

        public void AttachObserver(IClickObserver i_ClickObserver)
        {
            this.m_NotifyWhenClicked.Add(i_ClickObserver);
        }

        public void DetachObserver(IClickObserver i_ClickObserver)
        {
            this.m_NotifyWhenClicked.Remove(i_ClickObserver);
        }

        internal override void OnSelect()
        {
            Console.Clear();
            foreach (IClickObserver observer in this.m_NotifyWhenClicked)
            {
                observer.ReportClicked();
            }
            Thread.Sleep(2000);
            this.m_ParentMenu.Show();
        }
    }
}
