using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS
{
    public partial class EMS : Form
    {
        public string action;
        public List<EmployeeHiring> EmployeeList = new List<EmployeeHiring>();
        private EmployeeHiring ObjWork;
        public EMS()
        {
            InitializeComponent();
        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {   
            NewHiring Nh = new("NEW", EmployeeList.Count(), ObjWork)
            {
                Tag = this,
            };
            Nh.Show(this);
            this.Hide();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            ObjWork = LoadData();

             NewHiring Nh = new("MODIFY", Int32.Parse(ObjWork.Id.ToString()), ObjWork)
            {
                Tag = this,
            };
            Nh.Show(this);
            this.Hide();
        }

        private void ViewEmployee_Click(object sender, EventArgs e)
        {
            ObjWork = LoadData();
            NewHiring Nh = new("VIEW", Int32.Parse(ObjWork.Id.ToString()), ObjWork)
            {
                Tag = this,
            };
            Nh.Show(this);
            this.Hide();
        }

        public void LoadListData()
        {
            EmployeeData.Rows.Clear();

            foreach (EmployeeHiring item in EmployeeList)
            {
                EmployeeData.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                int rowID = EmployeeData.Rows.Add();
                DataGridViewRow row = EmployeeData.Rows[rowID];

                row.Cells["Vendor"].Value = item.GetID();
                row.Cells["FullName"].Value = item.GetFullName();
                row.Cells["FirstName"].Value = item.GetFirstName();
                row.Cells["LastName"].Value = item.GetLastName();
                row.Cells["DayOfBirth"].Value = item.GetDOB().ToShortDateString();
                row.Cells["Gender"].Value = item.GetGender();
                row.Cells["Address"].Value = item.GetAddress();
                row.Cells["Status"].Value = item.GetStatus("D");
                row.Cells["Area"].Value = item.GetArea();
                row.Cells["HiringDate"].Value = item.GetHiringDate().ToShortDateString();
                row.Cells["Salary"].Value = item.GetSalary();
                row.Cells["CreatedBy"].Value = item.GetCreatedBy();
                row.Cells["CreatedDate"].Value = item.GetCreatedDate().ToShortDateString();
                row.Cells["ModifiedBy"].Value = item.GetModifiedBy();
                row.Cells["ModifiedDate"].Value = item.GetModifiedDate().ToShortDateString();
            }

            //To resize the columns to fit the content
            for (int i = 0; i < EmployeeData.Columns.Count - 1; i++)
            {
                EmployeeData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            EmployeeData.Columns[EmployeeData.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < EmployeeData.Columns.Count; i++)
            {
                int colw = EmployeeData.Columns[i].Width;
                EmployeeData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                EmployeeData.Columns[i].Width = colw;
            }

            EmployeeData.Refresh();
        }

        public EmployeeHiring LoadData()
        {
            var Stat = "A";
            if (EmployeeData.CurrentRow.Cells[7].Value.ToString() == "Inactive") {
                Stat = "I";
            }
            EmployeeHiring ObjWorkView = new EmployeeHiring(
                                        Int32.Parse(EmployeeData.CurrentRow.Cells[0].Value.ToString()),
                                        EmployeeData.CurrentRow.Cells[2].Value.ToString(),
                                        EmployeeData.CurrentRow.Cells[3].Value.ToString(),
                                        DateTime.Parse(EmployeeData.CurrentRow.Cells[4].Value.ToString()),
                                        EmployeeData.CurrentRow.Cells[5].Value.ToString(),
                                        EmployeeData.CurrentRow.Cells[6].Value.ToString(),
                                        Stat,
                                        EmployeeData.CurrentRow.Cells[11].Value.ToString(),
                                        DateTime.Parse(EmployeeData.CurrentRow.Cells[12].Value.ToString()),
                                        EmployeeData.CurrentRow.Cells[13].Value.ToString(),
                                        DateTime.Parse(EmployeeData.CurrentRow.Cells[14].Value.ToString()),
                                        EmployeeData.CurrentRow.Cells[8].Value.ToString(),
                                        DateTime.Parse(EmployeeData.CurrentRow.Cells[9].Value.ToString()),
                                        float.Parse(EmployeeData.CurrentRow.Cells[10].Value.ToString())
                );

            return ObjWorkView;
        }
        //to automatically load on the opening
        private void EMS_Load(object sender, EventArgs e)
        {
            Tools LoadData = new Tools();
            if (LoadData.fileExist)
            {
                EmployeeList = LoadData.LoadFile();
            }
            LoadListData();
        }
        // to automatically save on the closing
        private void EMS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tools SaveData = new Tools();
            SaveData.SaveFile(EmployeeList);
            Application.Exit();
        }
        //to delete the object from the list
        private void delete_Click(object sender, EventArgs e)
        {
            ObjWork = LoadData();
            var index = EmployeeList.SingleOrDefault(x => x.Id == Int32.Parse(ObjWork.Id.ToString()));
            EmployeeList.Remove(index);
            LoadListData();
        }
        // to select the row based on the searchbox
        private void Search_Click(object sender, EventArgs e)
        {
            string searchValue = SearchBox.Text;
            EmployeeData.ClearSelection();
            EmployeeData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in EmployeeData.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("No results found for your search.");
            }


        }
    }
}
