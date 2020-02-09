namespace COMPANY_db_app
{
    partial class WorkItemsForm
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
            this.panelWithVariables = new System.Windows.Forms.Panel();
            this.dateTimePicker1DueDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox2Employeeid = new System.Windows.Forms.ComboBox();
            this.comboBox1Projectid = new System.Windows.Forms.ComboBox();
            this.richTextBox1Description = new System.Windows.Forms.RichTextBox();
            this.label1Name = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.label5DateDue = new System.Windows.Forms.Label();
            this.label2Description = new System.Windows.Forms.Label();
            this.label3Projectid = new System.Windows.Forms.Label();
            this.label4Employeeid = new System.Windows.Forms.Label();
            this.checkBox1AddEnabled = new System.Windows.Forms.CheckBox();
            this.label1Search = new System.Windows.Forms.Label();
            this.textBox1SearchBox = new System.Windows.Forms.TextBox();
            this.button1Search = new System.Windows.Forms.Button();
            this.dataGridView1WorkItems = new System.Windows.Forms.DataGridView();
            this.button1Cancel = new System.Windows.Forms.Button();
            this.button2Delete = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button4Add = new System.Windows.Forms.Button();
            this.workitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWithVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1WorkItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workitemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelWithVariables
            // 
            this.panelWithVariables.Controls.Add(this.dateTimePicker1DueDate);
            this.panelWithVariables.Controls.Add(this.comboBox2Employeeid);
            this.panelWithVariables.Controls.Add(this.comboBox1Projectid);
            this.panelWithVariables.Controls.Add(this.richTextBox1Description);
            this.panelWithVariables.Controls.Add(this.label1Name);
            this.panelWithVariables.Controls.Add(this.textBox1Name);
            this.panelWithVariables.Controls.Add(this.label5DateDue);
            this.panelWithVariables.Controls.Add(this.label2Description);
            this.panelWithVariables.Controls.Add(this.label3Projectid);
            this.panelWithVariables.Controls.Add(this.label4Employeeid);
            this.panelWithVariables.Location = new System.Drawing.Point(13, 13);
            this.panelWithVariables.Name = "panelWithVariables";
            this.panelWithVariables.Size = new System.Drawing.Size(659, 100);
            this.panelWithVariables.TabIndex = 0;
            // 
            // dateTimePicker1DueDate
            // 
            this.dateTimePicker1DueDate.Location = new System.Drawing.Point(345, 58);
            this.dateTimePicker1DueDate.Name = "dateTimePicker1DueDate";
            this.dateTimePicker1DueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1DueDate.TabIndex = 12;
            // 
            // comboBox2Employeeid
            // 
            this.comboBox2Employeeid.FormattingEnabled = true;
            this.comboBox2Employeeid.Location = new System.Drawing.Point(345, 30);
            this.comboBox2Employeeid.Name = "comboBox2Employeeid";
            this.comboBox2Employeeid.Size = new System.Drawing.Size(63, 21);
            this.comboBox2Employeeid.TabIndex = 11;
            // 
            // comboBox1Projectid
            // 
            this.comboBox1Projectid.FormattingEnabled = true;
            this.comboBox1Projectid.Location = new System.Drawing.Point(345, 3);
            this.comboBox1Projectid.Name = "comboBox1Projectid";
            this.comboBox1Projectid.Size = new System.Drawing.Size(63, 21);
            this.comboBox1Projectid.TabIndex = 10;
            // 
            // richTextBox1Description
            // 
            this.richTextBox1Description.Location = new System.Drawing.Point(71, 29);
            this.richTextBox1Description.Name = "richTextBox1Description";
            this.richTextBox1Description.Size = new System.Drawing.Size(179, 60);
            this.richTextBox1Description.TabIndex = 9;
            this.richTextBox1Description.Text = "";
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(3, 6);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(35, 13);
            this.label1Name.TabIndex = 0;
            this.label1Name.Text = "Name";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(71, 3);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(179, 20);
            this.textBox1Name.TabIndex = 5;
            // 
            // label5DateDue
            // 
            this.label5DateDue.AutoSize = true;
            this.label5DateDue.Location = new System.Drawing.Point(281, 64);
            this.label5DateDue.Name = "label5DateDue";
            this.label5DateDue.Size = new System.Drawing.Size(53, 13);
            this.label5DateDue.TabIndex = 4;
            this.label5DateDue.Text = "Date Due";
            // 
            // label2Description
            // 
            this.label2Description.AutoSize = true;
            this.label2Description.Location = new System.Drawing.Point(3, 32);
            this.label2Description.Name = "label2Description";
            this.label2Description.Size = new System.Drawing.Size(60, 13);
            this.label2Description.TabIndex = 1;
            this.label2Description.Text = "Description";
            // 
            // label3Projectid
            // 
            this.label3Projectid.AutoSize = true;
            this.label3Projectid.Location = new System.Drawing.Point(277, 6);
            this.label3Projectid.Name = "label3Projectid";
            this.label3Projectid.Size = new System.Drawing.Size(57, 13);
            this.label3Projectid.TabIndex = 2;
            this.label3Projectid.Text = "Project_ID";
            // 
            // label4Employeeid
            // 
            this.label4Employeeid.AutoSize = true;
            this.label4Employeeid.Location = new System.Drawing.Point(277, 33);
            this.label4Employeeid.Name = "label4Employeeid";
            this.label4Employeeid.Size = new System.Drawing.Size(70, 13);
            this.label4Employeeid.TabIndex = 3;
            this.label4Employeeid.Text = "Employee_ID";
            // 
            // checkBox1AddEnabled
            // 
            this.checkBox1AddEnabled.AutoSize = true;
            this.checkBox1AddEnabled.Location = new System.Drawing.Point(13, 332);
            this.checkBox1AddEnabled.Name = "checkBox1AddEnabled";
            this.checkBox1AddEnabled.Size = new System.Drawing.Size(137, 17);
            this.checkBox1AddEnabled.TabIndex = 1;
            this.checkBox1AddEnabled.Text = "Enable add work item ?";
            this.checkBox1AddEnabled.UseVisualStyleBackColor = true;
            this.checkBox1AddEnabled.CheckedChanged += new System.EventHandler(this.checkBox1AddEnabled_CheckedChanged);
            // 
            // label1Search
            // 
            this.label1Search.AutoSize = true;
            this.label1Search.Location = new System.Drawing.Point(302, 125);
            this.label1Search.Name = "label1Search";
            this.label1Search.Size = new System.Drawing.Size(81, 13);
            this.label1Search.TabIndex = 2;
            this.label1Search.Text = "Search projects";
            // 
            // textBox1SearchBox
            // 
            this.textBox1SearchBox.Location = new System.Drawing.Point(389, 122);
            this.textBox1SearchBox.Name = "textBox1SearchBox";
            this.textBox1SearchBox.Size = new System.Drawing.Size(202, 20);
            this.textBox1SearchBox.TabIndex = 3;
            this.textBox1SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1SearchBox_KeyPress);
            // 
            // button1Search
            // 
            this.button1Search.Location = new System.Drawing.Point(597, 119);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(75, 23);
            this.button1Search.TabIndex = 4;
            this.button1Search.Text = "Search";
            this.button1Search.UseVisualStyleBackColor = true;
            this.button1Search.Click += new System.EventHandler(this.button1Search_Click);
            // 
            // dataGridView1WorkItems
            // 
            this.dataGridView1WorkItems.AllowUserToAddRows = false;
            this.dataGridView1WorkItems.AllowUserToDeleteRows = false;
            this.dataGridView1WorkItems.AutoGenerateColumns = false;
            this.dataGridView1WorkItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1WorkItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1WorkItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateStartedDataGridViewTextBoxColumn,
            this.dateFinishedDataGridViewTextBoxColumn,
            this.dateDueDataGridViewTextBoxColumn});
            this.dataGridView1WorkItems.DataSource = this.workitemsBindingSource;
            this.dataGridView1WorkItems.Location = new System.Drawing.Point(13, 148);
            this.dataGridView1WorkItems.Name = "dataGridView1WorkItems";
            this.dataGridView1WorkItems.Size = new System.Drawing.Size(659, 172);
            this.dataGridView1WorkItems.TabIndex = 5;
            // 
            // button1Cancel
            // 
            this.button1Cancel.Location = new System.Drawing.Point(597, 326);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(75, 23);
            this.button1Cancel.TabIndex = 6;
            this.button1Cancel.Text = "Cancel";
            this.button1Cancel.UseVisualStyleBackColor = true;
            this.button1Cancel.Click += new System.EventHandler(this.button1Cancel_Click);
            // 
            // button2Delete
            // 
            this.button2Delete.Location = new System.Drawing.Point(516, 326);
            this.button2Delete.Name = "button2Delete";
            this.button2Delete.Size = new System.Drawing.Size(75, 23);
            this.button2Delete.TabIndex = 7;
            this.button2Delete.Text = "Delete";
            this.button2Delete.UseVisualStyleBackColor = true;
            this.button2Delete.Click += new System.EventHandler(this.button2Delete_Click);
            // 
            // button3Edit
            // 
            this.button3Edit.Location = new System.Drawing.Point(435, 326);
            this.button3Edit.Name = "button3Edit";
            this.button3Edit.Size = new System.Drawing.Size(75, 23);
            this.button3Edit.TabIndex = 8;
            this.button3Edit.Text = "Edit";
            this.button3Edit.UseVisualStyleBackColor = true;
            this.button3Edit.Click += new System.EventHandler(this.button3Edit_Click);
            // 
            // button4Add
            // 
            this.button4Add.Location = new System.Drawing.Point(354, 326);
            this.button4Add.Name = "button4Add";
            this.button4Add.Size = new System.Drawing.Size(75, 23);
            this.button4Add.TabIndex = 9;
            this.button4Add.Text = "Add";
            this.button4Add.UseVisualStyleBackColor = true;
            this.button4Add.Click += new System.EventHandler(this.button4Add_Click);
            // 
            // workitemsBindingSource
            // 
            this.workitemsBindingSource.DataSource = typeof(COMPANY_db_app.work_items);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee_Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Width = 93;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateCreatedDataGridViewTextBoxColumn.Width = 92;
            // 
            // dateStartedDataGridViewTextBoxColumn
            // 
            this.dateStartedDataGridViewTextBoxColumn.DataPropertyName = "DateStarted";
            this.dateStartedDataGridViewTextBoxColumn.HeaderText = "DateStarted";
            this.dateStartedDataGridViewTextBoxColumn.Name = "dateStartedDataGridViewTextBoxColumn";
            this.dateStartedDataGridViewTextBoxColumn.Width = 89;
            // 
            // dateFinishedDataGridViewTextBoxColumn
            // 
            this.dateFinishedDataGridViewTextBoxColumn.DataPropertyName = "DateFinished";
            this.dateFinishedDataGridViewTextBoxColumn.HeaderText = "DateFinished";
            this.dateFinishedDataGridViewTextBoxColumn.Name = "dateFinishedDataGridViewTextBoxColumn";
            this.dateFinishedDataGridViewTextBoxColumn.Width = 94;
            // 
            // dateDueDataGridViewTextBoxColumn
            // 
            this.dateDueDataGridViewTextBoxColumn.DataPropertyName = "DateDue";
            this.dateDueDataGridViewTextBoxColumn.HeaderText = "DateDue";
            this.dateDueDataGridViewTextBoxColumn.Name = "dateDueDataGridViewTextBoxColumn";
            this.dateDueDataGridViewTextBoxColumn.Width = 75;
            // 
            // WorkItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.button4Add);
            this.Controls.Add(this.button3Edit);
            this.Controls.Add(this.button2Delete);
            this.Controls.Add(this.button1Cancel);
            this.Controls.Add(this.dataGridView1WorkItems);
            this.Controls.Add(this.button1Search);
            this.Controls.Add(this.textBox1SearchBox);
            this.Controls.Add(this.label1Search);
            this.Controls.Add(this.checkBox1AddEnabled);
            this.Controls.Add(this.panelWithVariables);
            this.Name = "WorkItemsForm";
            this.Text = "WorkItemsForm";
            this.Load += new System.EventHandler(this.WorkItemsForm_Load);
            this.panelWithVariables.ResumeLayout(false);
            this.panelWithVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1WorkItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workitemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelWithVariables;
        private System.Windows.Forms.DateTimePicker dateTimePicker1DueDate;
        private System.Windows.Forms.ComboBox comboBox2Employeeid;
        private System.Windows.Forms.ComboBox comboBox1Projectid;
        private System.Windows.Forms.RichTextBox richTextBox1Description;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.Label label5DateDue;
        private System.Windows.Forms.Label label2Description;
        private System.Windows.Forms.Label label3Projectid;
        private System.Windows.Forms.Label label4Employeeid;
        private System.Windows.Forms.CheckBox checkBox1AddEnabled;
        private System.Windows.Forms.Label label1Search;
        private System.Windows.Forms.TextBox textBox1SearchBox;
        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.DataGridView dataGridView1WorkItems;
        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.Button button2Delete;
        private System.Windows.Forms.Button button3Edit;
        private System.Windows.Forms.Button button4Add;
        private System.Windows.Forms.BindingSource workitemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueDataGridViewTextBoxColumn;
    }
}