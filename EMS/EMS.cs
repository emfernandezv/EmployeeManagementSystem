using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class EMS : Form
    {
        public EMS()
        {
            InitializeComponent();
        }

        private void NewEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            NewHiring Nh = new()
            {
                Tag = this
            };
            Nh.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            NewHiring Nh = new()
            {
                Tag = this
            };
            Nh.Show(this);
        }
    }
}
