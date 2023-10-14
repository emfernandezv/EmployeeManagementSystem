using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Convert;
using static System.Net.Mime.MediaTypeNames;

namespace EMS
{
    public partial class NewHiring : Form
    {
        public string FormAction;
        protected EmployeeHiring EmployeeObj;
        int EmployeeSeed = 0;

        public NewHiring(string action, int seed, EmployeeHiring Obj)
        {
            FormAction = action;
            InitializeComponent();
            EmployeeObj = Obj;
            LoadForm(FormAction, Obj);
            EmployeeSeed = seed;


        }
        //to load the form according to the action
        private void LoadForm(string action, EmployeeHiring obj)
        {
            FirstName.Enabled = true;
            LastName.Enabled = true;
            DateOfBirth.Enabled = true;
            Gender.Enabled = true;
            Address.Enabled = true;
            StatusA.Enabled = true;
            StatusI.Enabled = true;
            Area.Enabled = true;
            Salary.Enabled = true;

            switch (action)
            {
                case "NEW":
                    this.Text = "New Employee";
                    HiringDate.Enabled = true;
                    FirstName.Focus();
                    break;
                case "MODIFY":
                    this.Text = "Modify Employee";
                    HiringDate.Enabled = false;
                    break;
                case "VIEW":
                    this.Text = "View Employee";
                    FirstName.Enabled = false;
                    LastName.Enabled = false;
                    DateOfBirth.Enabled = false;
                    Gender.Enabled = false;
                    Address.Enabled = false;
                    StatusA.Enabled = false;
                    StatusI.Enabled = false;
                    HiringDate.Enabled = false;
                    Area.Enabled = false;
                    Salary.Enabled = false;
                    Save.Enabled = false;
                    break;
            }

            if (action == "MODIFY" || action == "VIEW")
            {
                Id.Text = obj.Id.ToString();
                FirstName.Text = obj.GetFirstName();
                LastName.Text = obj.GetLastName();
                DateOfBirth.Text = obj.GetDOB().ToShortDateString();
                Gender.Text = obj.GetGender();
                Address.Text = obj.GetAddress();
                if(obj.GetStatus("C") == "A")
                {
                    StatusA.Checked = true;
                    StatusI.Checked = false;
                }
                else
                {
                    StatusA.Checked = false;
                    StatusI.Checked = true;
                }
                HiringDate.Text = obj.HiringDate.ToShortDateString();
                Area.Text = obj.Area.ToString();
                Salary.Text = obj.GetSalary().ToString();

                //AUDIT FIELDS
                CreatedBy.Text = obj.GetCreatedBy();
                CreatedDate.Text = obj.GetCreatedDate().ToString();
                ModifiedBy.Text = obj.GetModifiedBy(); 
                ModifiedDate.Text = obj.GetModifiedDate().ToString();
            }
        }
        
        //to validate text fields
        private int ValidateText(string fieldName, TextBox field)
        {
            if (field.Text == "" || field.Text == null || field.Text.Length < 2)// validates null or empty
            {
                MessageBox.Show($"You need to set a valid {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                field.Focus();
                field.BackColor = Color.LightPink;
                return -1;
            }
            else {
                field.BackColor = Color.White;
                return 1;
            };
        }
        //to validate float fields
        private int ValidateNumber(string fieldName, TextBox field)
        {
            float input;
            bool isNum = float.TryParse(field.Text, out input);
            if (!isNum) // if its not numeric
            {
                MessageBox.Show($"You may only use numeric characters in the field {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                field.Focus();
                field.BackColor = Color.LightPink;
                return -1;
            }
            else if (input < 0) // if the range is not met
            {
                MessageBox.Show($"Please use a number higher than 0 on field {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                field.Focus();
                field.BackColor = Color.LightPink;
                return -1;
            }
            else
            {
                field.BackColor = Color.White;
                return 1;
            };
            
        }
        //to validate combo box
        private int ValidateCombo(string fieldName, ComboBox field)
        {
            if (field.Text == "" || field.Text == null )// validates null or empty
            {
                MessageBox.Show($"You need to select a valid {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                field.Focus();
                field.BackColor = Color.LightPink;
                return -1;
            }
            else
            {
                field.BackColor = Color.White;
                return 1;
            };
        }

        private int FirstName_Validate()
        {
            return ValidateText("First Name", FirstName);
        }

        private int LastName_Validate()
        {
            return ValidateText("Last Name", LastName);
        }

        private void DateOfBirth_Validate()
        {

        }

        private int Gender_Validate()
        {
            return ValidateCombo("Gender", Gender);
        }

        private int Address_Validate()
        {
            return ValidateText("Address", Address);
        }

        private void StatusA_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusA.Checked == true) { 
                StatusI.Checked = false;
            }
            else
            {
                StatusI.Checked = true;
            }
        }

        private void StatusI_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusI.Checked == true)
            {
                StatusA.Checked = false;
            }
            else
            {
                StatusA.Checked = true;
            }
        }

        private void HiringDate_Validate()
        {

        }

        private int Area_Validate()
        {
           return ValidateCombo("Area", Area);
        }

        private int Salary_Validate()
        {
            return ValidateNumber("Salary", Salary);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            EMS MainList = (EMS)Tag;
            MainList.Show();
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (FirstName_Validate() > 0 
                && LastName_Validate() > 0
                && Gender_Validate() > 0
                && Address_Validate() > 0
                && Area_Validate() > 0  
                && Salary_Validate() > 0)
            {
                var status = "A";
                if (StatusA.Checked == true)
                {
                    status = "A";
                }
                else
                {
                    status = "I";
                }
                    
                EmployeeObj = new(      EmployeeSeed, 
                                        FirstName.Text, 
                                        LastName.Text,
                                        DateTime.Parse(DateOfBirth.Text), 
                                        Gender.Text, 
                                        Address.Text,
                                        status,
                                        Environment.UserName,
                                        DateTime.Now,
                                        Environment.UserName,
                                        DateTime.Now,
                                        Area.Text,
                                        DateTime.Parse(HiringDate.Text),
                                        float.Parse(Salary.Text)
                                      );

                EMS MainList = (EMS)Tag;
                if (FormAction == "NEW")
                {
                    MainList.EmployeeList.Add(EmployeeObj);
                }
                else
                {
                    var index = MainList.EmployeeList.FindIndex(x => x.Id == EmployeeSeed);
                    if (index > -1)
                    {
                        MainList.EmployeeList[index] = EmployeeObj;
                    }
                }
                
                MainList.LoadListData();
                MainList.Show();
                this.Close();

            }
        }




    }
}
