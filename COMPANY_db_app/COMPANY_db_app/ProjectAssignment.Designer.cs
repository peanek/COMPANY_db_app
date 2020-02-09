namespace COMPANY_db_app
{
    partial class ProjectAssignment
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
            this.panel1Variables = new System.Windows.Forms.Panel();
            this.label1ProjectId = new System.Windows.Forms.Label();
            this.comboBox1ProjectId = new System.Windows.Forms.ComboBox();
            this.comboBox2TeamId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1Add = new System.Windows.Forms.CheckBox();
            this.button1Cancel = new System.Windows.Forms.Button();
            this.button2Delete = new System.Windows.Forms.Button();
            this.button3Edit = new System.Windows.Forms.Button();
            this.button4Add = new System.Windows.Forms.Button();
            this.dataGridView1ProjectCooperation = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAssignedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectcooperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1Variables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1ProjectCooperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectcooperationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1Variables
            // 
            this.panel1Variables.Controls.Add(this.label1);
            this.panel1Variables.Controls.Add(this.comboBox2TeamId);
            this.panel1Variables.Controls.Add(this.comboBox1ProjectId);
            this.panel1Variables.Controls.Add(this.label1ProjectId);
            this.panel1Variables.Location = new System.Drawing.Point(13, 13);
            this.panel1Variables.Name = "panel1Variables";
            this.panel1Variables.Size = new System.Drawing.Size(559, 61);
            this.panel1Variables.TabIndex = 0;
            // 
            // label1ProjectId
            // 
            this.label1ProjectId.AutoSize = true;
            this.label1ProjectId.Location = new System.Drawing.Point(0, 3);
            this.label1ProjectId.Name = "label1ProjectId";
            this.label1ProjectId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1ProjectId.Size = new System.Drawing.Size(54, 13);
            this.label1ProjectId.TabIndex = 0;
            this.label1ProjectId.Text = "Project ID";
            // 
            // comboBox1ProjectId
            // 
            this.comboBox1ProjectId.FormattingEnabled = true;
            this.comboBox1ProjectId.Location = new System.Drawing.Point(92, 0);
            this.comboBox1ProjectId.Name = "comboBox1ProjectId";
            this.comboBox1ProjectId.Size = new System.Drawing.Size(121, 21);
            this.comboBox1ProjectId.TabIndex = 1;
            // 
            // comboBox2TeamId
            // 
            this.comboBox2TeamId.FormattingEnabled = true;
            this.comboBox2TeamId.Location = new System.Drawing.Point(92, 30);
            this.comboBox2TeamId.Name = "comboBox2TeamId";
            this.comboBox2TeamId.Size = new System.Drawing.Size(121, 21);
            this.comboBox2TeamId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team ID";
            // 
            // checkBox1Add
            // 
            this.checkBox1Add.AutoSize = true;
            this.checkBox1Add.Location = new System.Drawing.Point(12, 217);
            this.checkBox1Add.Name = "checkBox1Add";
            this.checkBox1Add.Size = new System.Drawing.Size(113, 17);
            this.checkBox1Add.TabIndex = 1;
            this.checkBox1Add.Text = "Add assignment ? ";
            this.checkBox1Add.UseVisualStyleBackColor = true;
            this.checkBox1Add.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1Cancel
            // 
            this.button1Cancel.Location = new System.Drawing.Point(497, 211);
            this.button1Cancel.Name = "button1Cancel";
            this.button1Cancel.Size = new System.Drawing.Size(75, 23);
            this.button1Cancel.TabIndex = 2;
            this.button1Cancel.Text = "Cancel";
            this.button1Cancel.UseVisualStyleBackColor = true;
            this.button1Cancel.Click += new System.EventHandler(this.button1Cancel_Click);
            // 
            // button2Delete
            // 
            this.button2Delete.Location = new System.Drawing.Point(416, 211);
            this.button2Delete.Name = "button2Delete";
            this.button2Delete.Size = new System.Drawing.Size(75, 23);
            this.button2Delete.TabIndex = 3;
            this.button2Delete.Text = "Delete";
            this.button2Delete.UseVisualStyleBackColor = true;
            this.button2Delete.Click += new System.EventHandler(this.button2Delete_Click);
            // 
            // button3Edit
            // 
            this.button3Edit.Location = new System.Drawing.Point(335, 211);
            this.button3Edit.Name = "button3Edit";
            this.button3Edit.Size = new System.Drawing.Size(75, 23);
            this.button3Edit.TabIndex = 4;
            this.button3Edit.Text = "Edit";
            this.button3Edit.UseVisualStyleBackColor = true;
            this.button3Edit.Click += new System.EventHandler(this.button3Edit_Click);
            // 
            // button4Add
            // 
            this.button4Add.Location = new System.Drawing.Point(254, 211);
            this.button4Add.Name = "button4Add";
            this.button4Add.Size = new System.Drawing.Size(75, 23);
            this.button4Add.TabIndex = 5;
            this.button4Add.Text = "Add";
            this.button4Add.UseVisualStyleBackColor = true;
            this.button4Add.Click += new System.EventHandler(this.button4Add_Click);
            // 
            // dataGridView1ProjectCooperation
            // 
            this.dataGridView1ProjectCooperation.AllowUserToAddRows = false;
            this.dataGridView1ProjectCooperation.AllowUserToDeleteRows = false;
            this.dataGridView1ProjectCooperation.AutoGenerateColumns = false;
            this.dataGridView1ProjectCooperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1ProjectCooperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1ProjectCooperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.projectIdDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn,
            this.dateAssignedDataGridViewTextBoxColumn});
            this.dataGridView1ProjectCooperation.DataSource = this.projectcooperationBindingSource;
            this.dataGridView1ProjectCooperation.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1ProjectCooperation.Name = "dataGridView1ProjectCooperation";
            this.dataGridView1ProjectCooperation.Size = new System.Drawing.Size(560, 135);
            this.dataGridView1ProjectCooperation.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // projectIdDataGridViewTextBoxColumn
            // 
            this.projectIdDataGridViewTextBoxColumn.DataPropertyName = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.HeaderText = "Project_Id";
            this.projectIdDataGridViewTextBoxColumn.Name = "projectIdDataGridViewTextBoxColumn";
            this.projectIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "Team_Id";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "Team_Id";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIdDataGridViewTextBoxColumn.Width = 74;
            // 
            // dateAssignedDataGridViewTextBoxColumn
            // 
            this.dateAssignedDataGridViewTextBoxColumn.DataPropertyName = "DateAssigned";
            this.dateAssignedDataGridViewTextBoxColumn.HeaderText = "DateAssigned";
            this.dateAssignedDataGridViewTextBoxColumn.Name = "dateAssignedDataGridViewTextBoxColumn";
            this.dateAssignedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAssignedDataGridViewTextBoxColumn.Width = 98;
            // 
            // projectcooperationBindingSource
            // 
            this.projectcooperationBindingSource.DataSource = typeof(COMPANY_db_app.project_cooperation);
            // 
            // ProjectAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 246);
            this.Controls.Add(this.dataGridView1ProjectCooperation);
            this.Controls.Add(this.button4Add);
            this.Controls.Add(this.button3Edit);
            this.Controls.Add(this.button2Delete);
            this.Controls.Add(this.button1Cancel);
            this.Controls.Add(this.checkBox1Add);
            this.Controls.Add(this.panel1Variables);
            this.Name = "ProjectAssignment";
            this.Text = "Project Assignment";
            this.Load += new System.EventHandler(this.ProjectAssignment_Load);
            this.panel1Variables.ResumeLayout(false);
            this.panel1Variables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1ProjectCooperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectcooperationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1Variables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2TeamId;
        private System.Windows.Forms.ComboBox comboBox1ProjectId;
        private System.Windows.Forms.Label label1ProjectId;
        private System.Windows.Forms.CheckBox checkBox1Add;
        private System.Windows.Forms.Button button1Cancel;
        private System.Windows.Forms.Button button2Delete;
        private System.Windows.Forms.Button button3Edit;
        private System.Windows.Forms.Button button4Add;
        private System.Windows.Forms.DataGridView dataGridView1ProjectCooperation;
        private System.Windows.Forms.BindingSource projectcooperationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAssignedDataGridViewTextBoxColumn;
    }
}