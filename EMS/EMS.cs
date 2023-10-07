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
        public string action;
        public List<EmployeeHiring> EmployeeList = new List<EmployeeHiring>();
        public EMS()
        {
            InitializeComponent();
        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {   
            NewHiring Nh = new("NEW", 0)
            {
                Tag = this,
            };
            Nh.Show(this);
            this.Hide();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            NewHiring Nh = new("MODIFY", 0)
            {
                Tag = this,
            };
            Nh.Show(this);
            this.Hide();
        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            NewHiring Nh = new("VIEW", 0)
            {
                Tag = this,
            };
            Nh.Show(this);
            this.Hide();
        }

        public void LoadData()
        {
            
        }

    }
}
