namespace COMPANY_db_app
{
    partial class ProjectsForm
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
            this.checkBox1AddProject = new System.Windows.Forms.CheckBox();
            this.button1Cancel = new System.Windows.Forms.Button();
            this.button2Delete = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button1Add = new System.Windows.Forms.Button();
            this.panelWithVariables = new System.Windows.Forms.Panel();
            this.label1Name = new System.Windows.Forms.Label();
            this.label2Manager = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox2Manager = new System.Windows.Forms.TextBox();
            this.dateTimePicker1DueDate = new System.Windows.Forms.DateTimePicker();
            this.label1DueDate = new System.Windows.Forms.Label();
            this.label1Search = new System.Windows.Forms.Label();
            this.textBox3SearchBox = new System.Windows.Forms.TextBox();
            this.button1Search = new System.Windows.Forms.Button();
            this.dataGridView1projects = new System.Windows.Forms.DataGridView();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectManagerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelWithVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1AddProject
            // 
            this.checkBox1AddProject.AutoSize = true;
            this.checkBox1AddProject.Location = new System.Drawing.Point(12, 316);
            this.checkBox1AddProject.Name = "checkBox1AddProject";
            this.checkBox1AddProject.Size = new System.Drawing.Size(121, 17);
            this.checkBox1AddProject.TabIndex = 0;
            this.checkBox1AddProject.Text = "Add project option? ";
            this.checkBox1AddProject.UseVisualStyleBackColor = true;
            this.checkBox1AddProject.CheckedChanged += new System.EventHandler(this.checkBox1AddProject_CheckedChanged);
            // 
            // button1Cancel
            // 
            this.button1Cancel.Location = new System.Drawing.Point(447, 312);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(75, 23);
            this.button1Cancel.TabIndex = 1;
            this.button1Cancel.Text = "Cancel";
            this.button1Cancel.UseVisualStyleBackColor = true;
            this.button1Cancel.Click += new System.EventHandler(this.button1Cancel_Click);
            // 
            // button2Delete
            // 
            this.button2Delete.Location = new System.Drawing.Point(366, 312);
            this.button2Delete.Name = "button2Delete";
            this.button2Delete.Size = new System.Drawing.Size(75, 23);
            this.button2Delete.TabIndex = 2;
            this.button2Delete.Text = "Delete";
            this.button2Delete.UseVisualStyleBackColor = true;
            this.button2Delete.Click += new System.EventHandler(this.button2Delete_Click);
            // 
            // button3Edit
            // 
            this.button3Edit.Location = new System.Drawing.Point(285, 312);
            this.button3Edit.Name = "button3Edit";
            this.button3Edit.Size = new System.Drawing.Size(75, 23);
            this.button3Edit.TabIndex = 3;
            this.button3Edit.Text = "Edit";
            this.button3Edit.UseVisualStyleBackColor = true;
            this.button3Edit.Click += new System.EventHandler(this.button3Edit_Click);
            // 
            // button1Add
            // 
            this.button1Add.Location = new System.Drawing.Point(204, 312);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(75, 23);
            this.button1Add.TabIndex = 4;
            this.button1Add.Text = "Add";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button4Add_Click);
            // 
            // panelWithVariables
            // 
            this.panelWithVariables.Controls.Add(this.label1DueDate);
            this.panelWithVariables.Controls.Add(this.dateTimePicker1DueDate);
            this.panelWithVariables.Controls.Add(this.textBox2Manager);
            this.panelWithVariables.Controls.Add(this.textBox1Name);
            this.panelWithVariables.Controls.Add(this.label2Manager);
            this.panelWithVariables.Controls.Add(this.label1Name);
            this.panelWithVariables.Location = new System.Drawing.Point(13, 13);
            this.panelWithVariables.Name = "panelWithVariables";
            this.panelWithVariables.Size = new System.Drawing.Size(509, 93);
            this.panelWithVariables.TabIndex = 5;
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(-1, 6);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(35, 13);
            this.label1Name.TabIndex = 0;
            this.label1Name.Text = "Name";
            // 
            // label2Manager
            // 
            this.label2Manager.AutoSize = true;
            this.label2Manager.Location = new System.Drawing.Point(-4, 32);
            this.label2Manager.Name = "label2Manager";
            this.label2Manager.Size = new System.Drawing.Size(94, 13);
            this.label2Manager.TabIndex = 1;
            this.label2Manager.Text = "Manager assigned";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(96, 3);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(150, 20);
            this.textBox1Name.TabIndex = 2;
            // 
            // textBox2Manager
            // 
            this.textBox2Manager.Location = new System.Drawing.Point(96, 29);
            this.textBox2Manager.Name = "textBox2Manager";
            this.textBox2Manager.Size = new System.Drawing.Size(150, 20);
            this.textBox2Manager.TabIndex = 3;
            // 
            // dateTimePicker1DueDate
            // 
            this.dateTimePicker1DueDate.Location = new System.Drawing.Point(96, 55);
            this.dateTimePicker1DueDate.MaxDate = new System.DateTime(2050, 12, 25, 23, 59, 0, 0);
            this.dateTimePicker1DueDate.MinDate = new System.DateTime(2020, 2, 9, 0, 0, 0, 0);
            this.dateTimePicker1DueDate.Name = "dateTimePicker1DueDate";
            this.dateTimePicker1DueDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1DueDate.TabIndex = 4;
            // 
            // label1DueDate
            // 
            this.label1DueDate.AutoSize = true;
            this.label1DueDate.Location = new System.Drawing.Point(-1, 61);
            this.label1DueDate.Name = "label1DueDate";
            this.label1DueDate.Size = new System.Drawing.Size(87, 13);
            this.label1DueDate.TabIndex = 5;
            this.label1DueDate.Text = "Project Due date";
            // 
            // label1Search
            // 
            this.label1Search.AutoSize = true;
            this.label1Search.Location = new System.Drawing.Point(172, 117);
            this.label1Search.Name = "label1Search";
            this.label1Search.Size = new System.Drawing.Size(76, 13);
            this.label1Search.TabIndex = 6;
            this.label1Search.Text = "Search project";
            // 
            // textBox3SearchBox
            // 
            this.textBox3SearchBox.Location = new System.Drawing.Point(254, 114);
            this.textBox3SearchBox.Name = "textBox3SearchBox";
            this.textBox3SearchBox.Size = new System.Drawing.Size(187, 20);
            this.textBox3SearchBox.TabIndex = 6;
            this.textBox3SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3SearchBox_KeyPress);
            // 
            // button1Search
            // 
            this.button1Search.Location = new System.Drawing.Point(447, 112);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(75, 23);
            this.button1Search.TabIndex = 7;
            this.button1Search.Text = "Search";
            this.button1Search.UseVisualStyleBackColor = true;
            this.button1Search.Click += new System.EventHandler(this.button1Search_Click);
            // 
            // dataGridView1projects
            // 
            this.dataGridView1projects.AllowUserToAddRows = false;
            this.dataGridView1projects.AllowUserToDeleteRows = false;
            this.dataGridView1projects.AutoGenerateColumns = false;
            this.dataGridView1projects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1projects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.projectManagerIdDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.dateDueDataGridViewTextBoxColumn});
            this.dataGridView1projects.DataSource = this.projectsBindingSource;
            this.dataGridView1projects.Location = new System.Drawing.Point(13, 140);
            this.dataGridView1projects.Name = "dataGridView1projects";
            this.dataGridView1projects.Size = new System.Drawing.Size(509, 166);
            this.dataGridView1projects.TabIndex = 8;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataSource = typeof(COMPANY_db_app.projects);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // projectManagerIdDataGridViewTextBoxColumn
            // 
            this.projectManagerIdDataGridViewTextBoxColumn.DataPropertyName = "ProjectManager_Id";
            this.projectManagerIdDataGridViewTextBoxColumn.HeaderText = "ProjectManager_Id";
            this.projectManagerIdDataGridViewTextBoxColumn.Name = "projectManagerIdDataGridViewTextBoxColumn";
            this.projectManagerIdDataGridViewTextBoxColumn.Width = 122;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateStartDataGridViewTextBoxColumn.Width = 77;
            // 
            // dateDueDataGridViewTextBoxColumn
            // 
            this.dateDueDataGridViewTextBoxColumn.DataPropertyName = "DateDue";
            this.dateDueDataGridViewTextBoxColumn.HeaderText = "DateDue";
            this.dateDueDataGridViewTextBoxColumn.Name = "dateDueDataGridViewTextBoxColumn";
            this.dateDueDataGridViewTextBoxColumn.Width = 75;
            // 
            // ProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.dataGridView1projects);
            this.Controls.Add(this.button1Search);
            this.Controls.Add(this.textBox3SearchBox);
            this.Controls.Add(this.label1Search);
            this.Controls.Add(this.panelWithVariables);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.button3Edit);
            this.Controls.Add(this.button2Delete);
            this.Controls.Add(this.button1Cancel);
            this.Controls.Add(this.checkBox1AddProject);
            this.Name = "ProjectsForm";
            this.Text = "ProjectsForm";
            this.Load += new System.EventHandler(this.ProjectsForm_Load);
            this.panelWithVariables.ResumeLayout(false);
            this.panelWithVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1AddProject;
        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.Button button2Delete;
        private System.Windows.Forms.Button button3Edit;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Panel panelWithVariables;
        private System.Windows.Forms.Label label2Manager;
        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.TextBox textBox2Manager;
        private System.Windows.Forms.Label label1DueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1DueDate;
        private System.Windows.Forms.Label label1Search;
        private System.Windows.Forms.TextBox textBox3SearchBox;
        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.DataGridView dataGridView1projects;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectManagerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDueDataGridViewTextBoxColumn;
    }
}