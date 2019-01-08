using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETABS_Plugin
{
    public class cPlugin
    {
        public void Main(ref ETABSv17.cSapModel SapModel, ref ETABSv17.cPluginCallback ISapPlugin)
        {
            Form1 form = new Form1(ref SapModel, ref ISapPlugin);
            form.Show();
        }

        public long Info(ref string Text)
        {
            Text = "my first plugin\n";
            return 0;
        }
    }
}
