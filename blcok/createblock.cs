using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NXOpen;
namespace block
{
    public partial class createblock : Form
    {
        private NXOpen.UF.UFSession theUFSession = NXOpen.UF.UFSession.GetUFSession();
        public createblock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NXOpen.UF.FeatureSigns signs = NXOpen.UF.FeatureSigns.Nullsign;
            double[] corner = new double[3] { 0, 0, 0 };
            Tag bl_tag;
            string[] aa = new string[3] { length.Text, width.Text, high.Text };
            theUFSession.Modl.CreateBlock1(signs, corner, aa, out bl_tag);

        }
    }
}
