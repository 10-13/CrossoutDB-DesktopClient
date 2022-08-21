using System;
using Routine;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace UI.Routine
{
    public partial class RoutineWindow : Form, UI.Workbench.IOverlayWindow
    {
        public readonly RoutineAction Routine;

        private bool CloseWithClick = true;
        private bool CloseWithTimer = true;
        private bool Ended = false;

        public event FormClosedEventHandler CloseAction;

        public RoutineWindow(in RoutineAction routine,bool CloseByTimer = true,bool CloseByClick = true)
        {
            Routine = routine;
            Routine.OnFineshed += OnRoutineEnd;
            InitializeComponent();
        }

        public RoutineWindow()
        {
            Routine = RoutineAction.GetWaitRoutine(1000);
            Routine.OnFineshed += OnRoutineEnd;
            InitializeComponent();
        }

        private void OnRoutineEnd()
        {
            Ended = true;
            this.BackColor = Color.PaleVioletRed;
            if(CloseWithTimer)
                Task.Run(() => { try { Thread.Sleep(4000); this.Invoke(new Action(() => { this.Close(); })); } catch (Exception ex) { } });
        }

        private void RoutineWindow_Click(object sender, EventArgs e)
        {
            if (Ended && CloseWithClick)
                this.Close();
        }

        private void RoutineWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAction.Invoke(sender, e);
        }
    }
}
