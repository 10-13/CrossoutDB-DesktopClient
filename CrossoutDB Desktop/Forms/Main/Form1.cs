using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Workbench;
using Routine;
using UI.Routine;

namespace CrossoutDB_Desktop
{
    public partial class Form1 : Workbench
    {
        public Form1()
        {
            InitializeComponent();
            RoutineAction routine = RoutineAction.GetWaitRoutine(1000);
            this.AddOverlayWindow(new RoutineWindow(in routine, true, true));
            this.AddOverlayWindow(new RoutineWindow(in routine, true, true));
            this.AddOverlayWindow(new RoutineWindow(in routine, true, true));
            this.UpdatePositions();
        }

    }
}
