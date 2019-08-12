using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluginVivado
{
    static class PluginExtensions
    {
        public static pluginVerilog.ProjectProperty GetVerilogPluginProperty(this codeEditor.Data.Project project)
        {
            return project.GetProjectProperty(pluginVerilog.Plugin.StaticID) as pluginVerilog.ProjectProperty;
        }

    }
}
