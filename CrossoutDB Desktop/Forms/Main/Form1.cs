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
using UI.Workbench.Funcionaloty;
using Routine;
using UI.Routine;

namespace CrossoutDB_Desktop
{
    public partial class Form1 : Workbench
    {
        public Form1()
        {
            InitializeComponent();
            {
                ToolStripMenuItem File = new ToolStripMenuItem("File");
                File.Name = "FileMenu";
                {
                    ToolStripButton Load = new ToolStripButton("Load");
                    Load.Click += __Menu_File_Load_Click;
                    ToolStripButton Close = new ToolStripButton("Close");
                    Close.Click += __Menu_File_Close_Click;

                    File.DropDownItems.AddRange(new ToolStripItem[2] { Load, Close });
                }
                MenuStrip menuStrip = new MenuStrip();
                this.Controls.Add(menuStrip);
                this.MainMenuStrip = menuStrip;
                this.MainMenuStrip.Items.AddRange(new ToolStripItem[1] { File });
                this.MainMenuStrip.Show();
            }
        }





        #region
        private const string __FileLoadQueryName = "FileLoadQuery";

        private OpenFileDialog __openFileDialog = new OpenFileDialog();
        private void __Menu_File_Load_Click(object sender, EventArgs e)
        {
            if (__openFileDialog.ShowDialog() == DialogResult.OK)
                if (externData.ContainsKey(__FileLoadQueryName) && externData[__FileLoadQueryName] is Load_Function[])
                    foreach (Load_Function func in externData[__FileLoadQueryName] as Load_Function[])
                        if (func(__openFileDialog.FileName))
                            return;
        }
        private void __Menu_File_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
