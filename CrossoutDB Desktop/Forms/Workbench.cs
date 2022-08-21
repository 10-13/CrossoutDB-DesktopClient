using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace UI.Workbench
{
    public abstract class Workbench : Form, IWorkbench
    {
        List<IOverlayWindow> windows = new List<IOverlayWindow>();

        public void AddOverlayWindow(IOverlayWindow window)
        {
            if(window is Form)
            {
                windows.Add(window);
                window.CloseAction += this.ChildClosed;
                if (window as Form == null)
                    throw new Exception();
                (window as Form).MdiParent = this;
                (window as Form).Show();
                (window as Form).Opacity = 0.32;
            }
            UpdatePositions();
        }

        public void ChildClosed(object sender, FormClosedEventArgs args)
        {
            if(sender is IOverlayWindow && windows.Contains(sender as IOverlayWindow))
            {
                windows.Remove(sender as IOverlayWindow);
            }
            UpdatePositions();
        }


        protected void UpdatePositions()
        {
            int PriviusEnd = 20;
            foreach(IOverlayWindow window in windows)
            {
                (window as Form).DesktopLocation = new Point(20, PriviusEnd);
                PriviusEnd += window.Size.Height + 20;
            }
        }
    }
    public interface IWorkbench
    {
        void AddOverlayWindow(IOverlayWindow window);
        void ChildClosed(object sender, FormClosedEventArgs args);
    }
    public interface IOverlayWindow
    {
        Point Location { get; set; }
        Size Size { get; set; }
        event FormClosedEventHandler CloseAction;
    }
}
