using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGitHub001
{
    public partial class TestProject001 : Form
    {
        public TestProject001()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtname.Text + "does not like programming. He has just been forced to study!");

        }
    }
}
