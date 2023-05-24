using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ajkControls.Primitive;

namespace pluginVivado
{
    public static class Global
    {
        public static SetupForm SetupForm = new SetupForm();
//        public static CodeDrawStyle CodeDrawStyle = new CodeDrawStyle();

        public static class Icons
        {
            //public static IconImage Exclamation = new IconImage(Properties.Resources.exclamation);
            //public static IconImage ExclamationBox = new IconImage(Properties.Resources.exclamationBox);
            public static IconImage Play = new IconImage(Properties.Resources.play);
            public static IconImage Pause = new IconImage(Properties.Resources.pause);
            public static IconImage Xilinx = new IconImage(Properties.Resources.xilinx);
        }
    }
}
