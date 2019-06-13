using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluginVivado
{
    public class SimulationTab : codeEditor.Controller.MainTabPage
    {
        public SimulationTab(pluginVerilog.Data.VerilogFile topFile):base ( new SimulationPanel(topFile),topFile.Name)
        {
            Text = topFile.Name;
            CloseButtonEnable = true;
            IconImage = codeEditor.Global.IconImages.Wave0;

            (panel as SimulationPanel).RequestTabIconChange += changeIcon;
            Controls.Add(panel);
        }

        private void changeIcon(ajkControls.IconImage iconImage)
        {
            Invoke(new Action(
                () => {
                    IconImage = iconImage;
                    Invalidate();
                }
                ));
        }

        public override void CloseButtonClicked()
        {
            codeEditor.Global.Controller.Tabs.RemovePage(this);
            panel.Dispose();
            Dispose();
        }
    }
}
