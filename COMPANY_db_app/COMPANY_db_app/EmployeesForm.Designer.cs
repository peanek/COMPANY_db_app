namespace COMPANY_db_app
{
    partial class EmployeesForm
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
            this.components = new System.ComponentModel.Container();
            this.label1FirstName = new System.Windows.Forms.Label();
            this.textBox1FirstName = new System.Windows.Forms.TextBox();
            this.textBox2MiddleNane = new System.Windows.Forms.TextBox();
            this.label2MiddleName = new System.Windows.Forms.Label();
            this.textBox3LastName = new System.Windows.Forms.TextBox();
            this.label3LastName = new System.Windows.Forms.Label();
            this.textBox4EmailAddress = new System.Windows.Forms.TextBox();
            this.label4EmailAddress = new System.Windows.Forms.Label();
            this.label5TeamNo = new System.Windows.Forms.Label();
            this.panelWithVariables = new System.Windows.Forms.Panel();
            this.comboBox2TeamNo = new System.Windows.Forms.ComboBox();
            this.comboBox1SearchItem = new System.Windows.Forms.ComboBox();
            this.textBox5SearchBox = new System.Windows.Forms.TextBox();
            this.label6SearchEmplyee = new System.Windows.Forms.Label();
            this.dataGridView1EmployessGrid = new System.Windows.Forms.DataGridView();
            this.button1Add = new System.Windows.Forms.Button();
            this.button2Edit = new System.Windows.Forms.Button();
            this.button3Cancel = new System.Windows.Forms.Button();
            this.button5Delete = new System.Windows.Forms.Button();
            this.checkBox1Editing = new System.Windows.Forms.CheckBox();
            this.button8Search = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelWithVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1EmployessGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1FirstName
            // 
            this.label1FirstName.AutoSize = true;
            this.label1FirstName.Location = new System.Drawing.Point(3, 10);
            this.label1FirstName.Name = "label1FirstName";
            this.label1FirstName.Size = new System.Drawing.Size(55, 13);
            this.label1FirstName.TabIndex = 0;
            this.label1FirstName.Text = "First name";
            // 
            // textBox1FirstName
            // 
            this.textBox1FirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.textBox1FirstName.Location = new System.Drawing.Point(86, 7);
            this.textBox1FirstName.Name = "textBox1FirstName";
            this.textBox1FirstName.Size = new System.Drawing.Size(171, 20);
            this.textBox1FirstName.TabIndex = 1;
            // 
            // textBox2MiddleNane
            // 
            this.textBox2MiddleNane.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Middlename", true));
            this.textBox2MiddleNane.Location = new System.Drawing.Point(86, 33);
            this.textBox2MiddleNane.Name = "textBox2MiddleNane";
            this.textBox2MiddleNane.Size = new System.Drawing.Size(171, 20);
            this.textBox2MiddleNane.TabIndex = 3;
            // 
            // label2MiddleName
            // 
            this.label2MiddleName.AutoSize = true;
            this.label2MiddleName.Location = new System.Drawing.Point(3, 36);
            this.label2MiddleName.Name = "label2MiddleName";
            this.label2MiddleName.Size = new System.Drawing.Size(67, 13);
            this.label2MiddleName.TabIndex = 2;
            this.label2MiddleName.Text = "Middle name";
            // 
            // textBox3LastName
            // 
            this.textBox3LastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.textBox3LastName.Location = new System.Drawing.Point(86, 59);
            this.textBox3LastName.Name = "textBox3LastName";
            this.textBox3LastName.Size = new System.Drawing.Size(171, 20);
            this.textBox3LastName.TabIndex = 5;
            // 
            // label3LastName
            // 
            this.label3LastName.AutoSize = true;
            this.label3LastName.Location = new System.Drawing.Point(3, 62);
            this.label3LastName.Name = "label3LastName";
            this.label3LastName.Size = new System.Drawing.Size(56, 13);
            this.label3LastName.TabIndex = 4;
            this.label3LastName.Text = "Last name";
            // 
            // textBox4EmailAddress
            // 
            this.textBox4EmailAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Email", true));
            this.textBox4EmailAddress.Location = new System.Drawing.Point(86, 85);
            this.textBox4EmailAddress.Name = "textBox4EmailAddress";
            this.textBox4EmailAddress.Size = new System.Drawing.Size(171, 20);
            this.textBox4EmailAddress.TabIndex = 7;
            // 
            // label4EmailAddress
            // 
            this.label4EmailAddress.AutoSize = true;
            this.label4EmailAddress.Location = new System.Drawing.Point(3, 88);
            this.label4EmailAddress.Name = "label4EmailAddress";
            this.label4EmailAddress.Size = new System.Drawing.Size(77, 13);
            this.label4EmailAddress.TabIndex = 6;
            this.label4EmailAddress.Text = "Email addresss";
            // 
            // label5TeamNo
            // 
            this.label5TeamNo.AutoSize = true;
            this.label5TeamNo.Location = new System.Drawing.Point(3, 114);
            this.label5TeamNo.Name = "label5TeamNo";
            this.label5TeamNo.Size = new System.Drawing.Size(52, 13);
            this.label5TeamNo.TabIndex = 8;
            this.label5TeamNo.Text = "Team no.";
            // 
            // panelWithVariables
            // 
            this.panelWithVariables.Controls.Add(this.comboBox2TeamNo);
            this.panelWithVariables.Controls.Add(this.label1FirstName);
            this.panelWithVariables.Controls.Add(this.label5TeamNo);
            this.panelWithVariables.Controls.Add(this.textBox1FirstName);
            this.panelWithVariables.Controls.Add(this.textBox4EmailAddress);
            this.panelWithVariables.Controls.Add(this.label2MiddleName);
            this.panelWithVariables.Controls.Add(this.label4EmailAddress);
            this.panelWithVariables.Controls.Add(this.textBox2MiddleNane);
            this.panelWithVariables.Controls.Add(this.textBox3LastName);
            this.panelWithVariables.Controls.Add(this.label3LastName);
            this.panelWithVariables.Location = new System.Drawing.Point(12, 12);
            this.panelWithVariables.Name = "panelWithVariables";
            this.panelWithVariables.Size = new System.Drawing.Size(500, 142);
            this.panelWithVariables.TabIndex = 10;
            // 
            // comboBox2TeamNo
            // 
            this.comboBox2TeamNo.FormattingEnabled = true;
            this.comboBox2TeamNo.Items.AddRange(new object[] {
            "First Name",
            "Middle Name",
            "Last Name"});
            this.comboBox2TeamNo.Location = new System.Drawing.Point(86, 111);
            this.comboBox2TeamNo.Name = "comboBox2TeamNo";
            this.comboBox2TeamNo.Size = new System.Drawing.Size(121, 21);
            this.comboBox2TeamNo.TabIndex = 17;
            // 
            // comboBox1SearchItem
            // 
            this.comboBox1SearchItem.FormattingEnabled = true;
            this.comboBox1SearchItem.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Email"});
            this.comboBox1SearchItem.Location = new System.Drawing.Point(138, 193);
            this.comboBox1SearchItem.Name = "comboBox1SearchItem";
            this.comboBox1SearchItem.Size = new System.Drawing.Size(121, 21);
            this.comboBox1SearchItem.TabIndex = 13;
            // 
            // textBox5SearchBox
            // 
            this.textBox5SearchBox.Location = new System.Drawing.Point(265, 193);
            this.textBox5SearchBox.Name = "textBox5SearchBox";
            this.textBox5SearchBox.Size = new System.Drawing.Size(177, 20);
            this.textBox5SearchBox.TabIndex = 11;
            this.textBox5SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5SearchBox_KeyPress);
            // 
            // label6SearchEmplyee
            // 
            this.label6SearchEmplyee.AutoSize = true;
            this.label6SearchEmplyee.Location = new System.Drawing.Point(26, 196);
            this.label6SearchEmplyee.Name = "label6SearchEmplyee";
            this.label6SearchEmplyee.Size = new System.Drawing.Size(90, 13);
            this.label6SearchEmplyee.TabIndex = 10;
            this.label6SearchEmplyee.Text = "Search Employee";
            // 
            // dataGridView1EmployessGrid
            // 
            this.dataGridView1EmployessGrid.AllowUserToAddRows = false;
            this.dataGridView1EmployessGrid.AllowUserToDeleteRows = false;
            this.dataGridView1EmployessGrid.AutoGenerateColumns = false;
            this.dataGridView1EmployessGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1EmployessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1EmployessGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn});
            this.dataGridView1EmployessGrid.DataSource = this.employeesBindingSource;
            this.dataGridView1EmployessGrid.Location = new System.Drawing.Point(9, 219);
            this.dataGridView1EmployessGrid.Name = "dataGridView1EmployessGrid";
            this.dataGridView1EmployessGrid.ReadOnly = true;
            this.dataGridView1EmployessGrid.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1EmployessGrid.TabIndex = 11;
            // 
            // button1Add
            // 
            this.button1Add.Location = new System.Drawing.Point(205, 375);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(75, 23);
            this.button1Add.TabIndex = 12;
            this.button1Add.Text = "Add";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // button2Edit
            // 
            this.button2Edit.Location = new System.Drawing.Point(286, 375);
            this.button2Edit.Name = "button2Edit";
            this.button2Edit.Size = new System.Drawing.Size(75, 23);
            this.button2Edit.TabIndex = 13;
            this.button2Edit.Text = "Edit";
            this.button2Edit.UseVisualStyleBackColor = true;
            this.button2Edit.Click += new System.EventHandler(this.button2Edit_Click);
            // 
            // button3Cancel
            // 
            this.button3Cancel.Location = new System.Drawing.Point(448, 375);
            this.button3Cancel.Name = "button3Cancel";
            this.button3Cancel.Size = new System.Drawing.Size(75, 23);
            this.button3Cancel.TabIndex = 14;
            this.button3Cancel.Text = "Cancel";
            this.button3Cancel.UseVisualStyleBackColor = true;
            this.button3Cancel.Click += new System.EventHandler(this.button4Cancel_Click);
            // 
            // button5Delete
            // 
            this.button5Delete.Location = new System.Drawing.Point(367, 375);
            this.button5Delete.Name = "button5Delete";
            this.button5Delete.Size = new System.Drawing.Size(75, 23);
            this.button5Delete.TabIndex = 16;
            this.button5Delete.Text = "Delete";
            this.button5Delete.UseVisualStyleBackColor = true;
            this.button5Delete.Click += new System.EventHandler(this.button5Delete_Click);
            // 
            // checkBox1Editing
            // 
            this.checkBox1Editing.AutoSize = true;
            this.checkBox1Editing.Location = new System.Drawing.Point(12, 381);
            this.checkBox1Editing.Name = "checkBox1Editing";
            this.checkBox1Editing.Size = new System.Drawing.Size(134, 17);
            this.checkBox1Editing.TabIndex = 16;
            this.checkBox1Editing.Text = "Add employee option ?";
            this.checkBox1Editing.UseVisualStyleBackColor = true;
            this.checkBox1Editing.CheckedChanged += new System.EventHandler(this.checkBox1Editing_CheckedChanged);
            // 
            // button8Search
            // 
            this.button8Search.Location = new System.Drawing.Point(448, 191);
            this.button8Search.Name = "button8Search";
            this.button8Search.Size = new System.Drawing.Size(75, 23);
            this.button8Search.TabIndex = 17;
            this.button8Search.Text = "Search";
            this.button8Search.UseVisualStyleBackColor = true;
            this.button8Search.Click += new System.EventHandler(this.button8Search_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "Middlename";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            this.middlenameDataGridViewTextBoxColumn.Width = 89;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "Team_Id";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "Team_Id";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.Width = 74;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(COMPANY_db_app.employees);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(COMPANY_db_app.teams);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 401);
            this.Controls.Add(this.button8Search);
            this.Controls.Add(this.checkBox1Editing);
            this.Controls.Add(this.button5Delete);
            this.Controls.Add(this.textBox5SearchBox);
            this.Controls.Add(this.comboBox1SearchItem);
            this.Controls.Add(this.button3Cancel);
            this.Controls.Add(this.label6SearchEmplyee);
            this.Controls.Add(this.button2Edit);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.dataGridView1EmployessGrid);
            this.Controls.Add(this.panelWithVariables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeesForm";
            this.Text = "Employees Edit";
            this.Load += new System.EventHandler(this.EmplyeesForm_Load);
            this.panelWithVariables.ResumeLayout(false);
            this.panelWithVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1EmployessGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1FirstName;
        private System.Windows.Forms.TextBox textBox1FirstName;
        private System.Windows.Forms.TextBox textBox2MiddleNane;
        private System.Windows.Forms.Label label2MiddleName;
        private System.Windows.Forms.TextBox textBox3LastName;
        private System.Windows.Forms.Label label3LastName;
        private System.Windows.Forms.TextBox textBox4EmailAddress;
        private System.Windows.Forms.Label label4EmailAddress;
        private System.Windows.Forms.Label label5TeamNo;
        private System.Windows.Forms.Panel panelWithVariables;
        private System.Windows.Forms.Label label6SearchEmplyee;
        private System.Windows.Forms.TextBox textBox5SearchBox;
        private System.Windows.Forms.DataGridView dataGridView1EmployessGrid;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button button2Edit;
        private System.Windows.Forms.Button button3Cancel;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.ComboBox comboBox1SearchItem;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5Delete;
        private System.Windows.Forms.CheckBox checkBox1Editing;
        private System.Windows.Forms.ComboBox comboBox2TeamNo;
        private System.Windows.Forms.Button button8Search;
    }
}