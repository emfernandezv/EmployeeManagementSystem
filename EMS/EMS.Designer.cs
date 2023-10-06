namespace EMS
{
    partial class EMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMS));
            this.NewEmployee = new System.Windows.Forms.Button();
            this.EditEmployee = new System.Windows.Forms.Button();
            this.ViewEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HiringDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchTag = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewEmployee
            // 
            this.NewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmployee.Location = new System.Drawing.Point(1362, 21);
            this.NewEmployee.Name = "NewEmployee";
            this.NewEmployee.Size = new System.Drawing.Size(87, 37);
            this.NewEmployee.TabIndex = 0;
            this.NewEmployee.Text = "&Add";
            this.NewEmployee.UseVisualStyleBackColor = true;
            this.NewEmployee.Click += new System.EventHandler(this.NewEmployee_Click);
            // 
            // EditEmployee
            // 
            this.EditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployee.Location = new System.Drawing.Point(1455, 21);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Size = new System.Drawing.Size(87, 37);
            this.EditEmployee.TabIndex = 1;
            this.EditEmployee.Text = "&Edit";
            this.EditEmployee.UseVisualStyleBackColor = true;
            // 
            // ViewEmployee
            // 
            this.ViewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployee.Location = new System.Drawing.Point(1548, 21);
            this.ViewEmployee.Name = "ViewEmployee";
            this.ViewEmployee.Size = new System.Drawing.Size(87, 37);
            this.ViewEmployee.TabIndex = 2;
            this.ViewEmployee.Text = "&View";
            this.ViewEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vendor,
            this.FullName,
            this.DayOfBirth,
            this.Gender,
            this.Address,
            this.Status,
            this.Area,
            this.HiringDate,
            this.Salary,
            this.CreatedBy,
            this.CreatedDate,
            this.ModifiedBy,
            this.ModifiedDate});
            this.dataGridView1.Location = new System.Drawing.Point(24, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1611, 929);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Vendor
            // 
            this.Vendor.HeaderText = "ID";
            this.Vendor.MinimumWidth = 8;
            this.Vendor.Name = "Vendor";
            this.Vendor.Width = 150;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // DayOfBirth
            // 
            this.DayOfBirth.HeaderText = "DOB";
            this.DayOfBirth.MinimumWidth = 8;
            this.DayOfBirth.Name = "DayOfBirth";
            this.DayOfBirth.Width = 150;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 8;
            this.Gender.Name = "Gender";
            this.Gender.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Adress";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 8;
            this.Area.Name = "Area";
            this.Area.Width = 150;
            // 
            // HiringDate
            // 
            this.HiringDate.HeaderText = "Hiring Date";
            this.HiringDate.MinimumWidth = 8;
            this.HiringDate.Name = "HiringDate";
            this.HiringDate.Width = 150;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 8;
            this.Salary.Name = "Salary";
            this.Salary.Width = 150;
            // 
            // CreatedBy
            // 
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.MinimumWidth = 8;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Width = 150;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.MinimumWidth = 8;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Width = 150;
            // 
            // ModifiedBy
            // 
            this.ModifiedBy.HeaderText = "ModifiedBy";
            this.ModifiedBy.MinimumWidth = 8;
            this.ModifiedBy.Name = "ModifiedBy";
            this.ModifiedBy.Width = 150;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.HeaderText = "ModifiedDate";
            this.ModifiedDate.MinimumWidth = 8;
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ModifiedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ModifiedDate.Width = 150;
            // 
            // SearchTag
            // 
            this.SearchTag.AutoSize = true;
            this.SearchTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTag.Location = new System.Drawing.Point(29, 25);
            this.SearchTag.Name = "SearchTag";
            this.SearchTag.Size = new System.Drawing.Size(191, 29);
            this.SearchTag.TabIndex = 4;
            this.SearchTag.Text = "Search by Name";
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(226, 23);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(297, 35);
            this.SearchBox.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(539, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 33);
            this.Search.TabIndex = 6;
            this.Search.Text = "&Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // EMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1055);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchTag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewEmployee);
            this.Controls.Add(this.EditEmployee);
            this.Controls.Add(this.NewEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EMS";
            this.Text = "Employee Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewEmployee;
        private System.Windows.Forms.Button EditEmployee;
        private System.Windows.Forms.Button ViewEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SearchTag;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiringDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
    }
}

