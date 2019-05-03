using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluginVivado
{
    public class Plugin : codeEditorPlugin.IPlugin
    {
        public void Initialize()
        {
            // register filetype
//            {
//                FileTypes.VerilogFile fileType = new FileTypes.VerilogFile();
//                codeEditor.Global.FileTypes.Add(fileType.ID, fileType);
//            }
//            {
//                FileTypes.VerilogHeaderFile fileType = new FileTypes.VerilogHeaderFile();
//                codeEditor.Global.FileTypes.Add(fileType.ID, fileType);
//            }

            System.Windows.Forms.ContextMenuStrip menu = codeEditor.Global.Controller.NavigatePanel.GetContextMenuStrip();
            menu.Items.Add(Global.SetupForm.runXSimToolStripMenuItem);
        }

        public string Id { get { return StaticID; } }

        public static string StaticID = "Vivado";
    }
}
