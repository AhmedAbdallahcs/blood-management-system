using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class donation : Form
    {
        public donation()
        {
            InitializeComponent();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            donors d3 = new donors();
            d3.Show();
        }

        private void invantoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            invantory d4 = new invantory();
            d4.Show();
        }
    }
}
