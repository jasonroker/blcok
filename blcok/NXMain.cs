using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace block
{
    public class NXMain
    {
        public static int Main(string[] args)
        {
            int retValue = 0;
            try
            {
                string ButtonName = args[0];
                if (ButtonName.Equals("CreateBlock"))
                {
                    createblock bl = new createblock();
                    bl.Show();
                }
                MessageBox.Show("HELLO,MY FRIEND!");
            }
            catch (NXOpen.NXException error)
            {
                // ---- Enter your exception handling code here -----
                MessageBox.Show(error.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retValue;
        }
    }
}
