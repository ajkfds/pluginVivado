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

            runXSimTsmi.Image = codeEditor.Global.IconImages.Play.GetImage(
               codeEditor.Controller.NavigatePanel.GetContextMenuStrip().ImageScalingSize.Height,
               ajkControls.IconImage.ColorStyle.Blue);

            XilinxTsmi.Image = Global.Icons.Xilinx.GetImage(
               codeEditor.Controller.NavigatePanel.GetContextMenuStrip().ImageScalingSize.Height,
               ajkControls.IconImage.ColorStyle.Original);
        }

        private void RunXSimTsmi_Click(object sender, EventArgs e)
        {
            codeEditor.NavigatePanel.NavigatePanelNode node;
            codeEditor.Controller.NavigatePanel.GetSelectedNode(out node);

            pluginVerilog.NavigatePanel.VerilogFileNode vnode = node as pluginVerilog.NavigatePanel.VerilogFileNode;
            if (vnode == null) return;

            pluginVerilog.Data.VerilogFile topFile = vnode.VerilogFile;
            if (topFile == null) return;

            SimulationPanel panel = new SimulationPanel(topFile);
            codeEditor.Tabs.MainTabPage mainTabPage = new SimulationTab(topFile);
            codeEditor.Controller.Tabs.AddPage(mainTabPage);
        }

        private void VivadoGUITsmi_Click(object sender, EventArgs e)
        {

        }
    }
}
