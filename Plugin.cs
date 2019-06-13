using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluginVivado
{
    public class Plugin : codeEditorPlugin.IPlugin
    {
        public bool Register()
        {
            // checklibrary  dependency
            if (!codeEditor.Global.Plugins.ContainsKey("Verilog")) return false;

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
            menu.Items.Insert(0,Global.SetupForm.XilinxTsmi);

            pluginVerilog.NavigatePanel.VerilogFileNode.NodeCreated += new Action<pluginVerilog.NavigatePanel.VerilogFileNode>(
                node => {
                    node.NodeSelected += new Action(
                        () => {
                            codeEditor.Global.Controller.NavigatePanel.GetContextMenuStrip().Items["XilinxTsmi"].Visible = true;
                        }
                        );
                }
                );
            return true;
        }

        public bool Initialize()
        {
            return true;
        }

        public string Id { get { return StaticID; } }

        public static string StaticID = "Vivado";
    }
}
