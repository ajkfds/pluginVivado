using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pluginVivado
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();

            runXSimToolStripMenuItem.Image = Global.Icons.Play.GetImage(
               codeEditor.Global.Controller.NavigatePanel.GetContextMenuStrip().ImageScalingSize.Height,
               ajkControls.IconImage.ColorStyle.Blue);
        }

        private void runXSimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string projectName, id;
            codeEditor.Global.Controller.NavigatePanel.GetSelectedNode(out projectName, out id);

            codeEditor.Data.Project project = codeEditor.Global.Projects[projectName];
            pluginVerilog.Data.VerilogFile topFile = project.GetRegisterdItem(id) as pluginVerilog.Data.VerilogFile;
            if (topFile == null) return;

            //ajkControls.TabPage page = new IcarusVerilog.SimulationTab(topFile);
            //codeEditor.Global.Controller.Tabs.AddPage(page);



            SimulationPanel panel = new SimulationPanel(topFile);
            codeEditor.Controller.MainTabPage mainTabPage = new codeEditor.Controller.MainTabPage(panel, topFile.Name);
            codeEditor.Global.Controller.Tabs.AddPage(mainTabPage);
        }
    }
}
