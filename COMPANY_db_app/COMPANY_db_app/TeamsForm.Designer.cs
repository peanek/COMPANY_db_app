namespace COMPANY_db_app
{
    partial class TeamsForm
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
            this.label1Name = new System.Windows.Forms.Label();
            this.textBox1TeamName = new System.Windows.Forms.TextBox();
            this.panel1Variables = new System.Windows.Forms.Panel();
            this.label1SearchTeam = new System.Windows.Forms.Label();
            this.textBox2SearchBox = new System.Windows.Forms.TextBox();
            this.checkBox1AddOption = new System.Windows.Forms.CheckBox();
            this.button1Add = new System.Windows.Forms.Button();
            this.button2Edit = new System.Windows.Forms.Button();
            this.button3Delete = new System.Windows.Forms.Button();
            this.button4Cancel = new System.Windows.Forms.Button();
            this.dataGridView1Teams = new System.Windows.Forms.DataGridView();
            this.button1Search = new System.Windows.Forms.Button();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1Variables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(3, 10);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(65, 13);
            this.label1Name.TabIndex = 0;
            this.label1Name.Text = "Team Name";
            // 
            // textBox1TeamName
            // 
            this.textBox1TeamName.Location = new System.Drawing.Point(74, 7);
            this.textBox1TeamName.Name = "textBox1TeamName";
            this.textBox1TeamName.Size = new System.Drawing.Size(144, 20);
            this.textBox1TeamName.TabIndex = 1;
            // 
            // panel1Variables
            // 
            this.panel1Variables.Controls.Add(this.textBox1TeamName);
            this.panel1Variables.Controls.Add(this.label1Name);
            this.panel1Variables.Location = new System.Drawing.Point(12, 12);
            this.panel1Variables.Name = "panel1Variables";
            this.panel1Variables.Size = new System.Drawing.Size(410, 35);
            this.panel1Variables.TabIndex = 2;
            // 
            // label1SearchTeam
            // 
            this.label1SearchTeam.AutoSize = true;
            this.label1SearchTeam.Location = new System.Drawing.Point(72, 50);
            this.label1SearchTeam.Name = "label1SearchTeam";
            this.label1SearchTeam.Size = new System.Drawing.Size(71, 13);
            this.label1SearchTeam.TabIndex = 3;
            this.label1SearchTeam.Text = "Search Team";
            // 
            // textBox2SearchBox
            // 
            this.textBox2SearchBox.Location = new System.Drawing.Point(149, 47);
            this.textBox2SearchBox.Name = "textBox2SearchBox";
            this.textBox2SearchBox.Size = new System.Drawing.Size(192, 20);
            this.textBox2SearchBox.TabIndex = 4;
            this.textBox2SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2SearchBox_KeyPress);
            // 
            // checkBox1AddOption
            // 
            this.checkBox1AddOption.AutoSize = true;
            this.checkBox1AddOption.Location = new System.Drawing.Point(12, 235);
            this.checkBox1AddOption.Name = "checkBox1AddOption";
            this.checkBox1AddOption.Size = new System.Drawing.Size(80, 17);
            this.checkBox1AddOption.TabIndex = 5;
            this.checkBox1AddOption.Text = "Add team ?";
            this.checkBox1AddOption.UseVisualStyleBackColor = true;
            this.checkBox1AddOption.CheckedChanged += new System.EventHandler(this.checkBox1AddOption_CheckedChanged);
            // 
            // button1Add
            // 
            this.button1Add.Location = new System.Drawing.Point(104, 229);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(75, 23);
            this.button1Add.TabIndex = 6;
            this.button1Add.Text = "Add";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // button2Edit
            // 
            this.button2Edit.Location = new System.Drawing.Point(185, 229);
            this.button2Edit.Name = "button2Edit";
            this.button2Edit.Size = new System.Drawing.Size(75, 23);
            this.button2Edit.TabIndex = 7;
            this.button2Edit.Text = "Edit";
            this.button2Edit.UseVisualStyleBackColor = true;
            this.button2Edit.Click += new System.EventHandler(this.button2Edit_Click);
            // 
            // button3Delete
            // 
            this.button3Delete.Location = new System.Drawing.Point(266, 229);
            this.button3Delete.Name = "button3Delete";
            this.button3Delete.Size = new System.Drawing.Size(75, 23);
            this.button3Delete.TabIndex = 8;
            this.button3Delete.Text = "Delete";
            this.button3Delete.UseVisualStyleBackColor = true;
            this.button3Delete.Click += new System.EventHandler(this.button3Delete_Click);
            // 
            // button4Cancel
            // 
            this.button4Cancel.Location = new System.Drawing.Point(347, 229);
            this.button4Cancel.Name = "button4Cancel";
            this.button4Cancel.Size = new System.Drawing.Size(75, 23);
            this.button4Cancel.TabIndex = 9;
            this.button4Cancel.Text = "Cancel";
            this.button4Cancel.UseVisualStyleBackColor = true;
            this.button4Cancel.Click += new System.EventHandler(this.button4Cancel_Click);
            // 
            // dataGridView1Teams
            // 
            this.dataGridView1Teams.AllowUserToAddRows = false;
            this.dataGridView1Teams.AllowUserToDeleteRows = false;
            this.dataGridView1Teams.AutoGenerateColumns = false;
            this.dataGridView1Teams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1Teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Teams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1Teams.DataSource = this.teamsBindingSource;
            this.dataGridView1Teams.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1Teams.Name = "dataGridView1Teams";
            this.dataGridView1Teams.Size = new System.Drawing.Size(410, 139);
            this.dataGridView1Teams.TabIndex = 10;
            // 
            // button1Search
            // 
            this.button1Search.Location = new System.Drawing.Point(347, 45);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(75, 23);
            this.button1Search.TabIndex = 11;
            this.button1Search.Text = "Search";
            this.button1Search.UseVisualStyleBackColor = true;
            this.button1Search.Click += new System.EventHandler(this.button1Search_Click);
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataSource = typeof(COMPANY_db_app.teams);
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
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.button1Search);
            this.Controls.Add(this.dataGridView1Teams);
            this.Controls.Add(this.button4Cancel);
            this.Controls.Add(this.button3Delete);
            this.Controls.Add(this.button2Edit);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.checkBox1AddOption);
            this.Controls.Add(this.textBox2SearchBox);
            this.Controls.Add(this.label1SearchTeam);
            this.Controls.Add(this.panel1Variables);
            this.Name = "TeamsForm";
            this.Text = "Teams Edit";
            this.Load += new System.EventHandler(this.TeamsForm_Load);
            this.panel1Variables.ResumeLayout(false);
            this.panel1Variables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Name;
        private System.Windows.Forms.TextBox textBox1TeamName;
        private System.Windows.Forms.Panel panel1Variables;
        private System.Windows.Forms.Label label1SearchTeam;
        private System.Windows.Forms.TextBox textBox2SearchBox;
        private System.Windows.Forms.CheckBox checkBox1AddOption;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button button2Edit;
        private System.Windows.Forms.Button button3Delete;
        private System.Windows.Forms.Button button4Cancel;
        private System.Windows.Forms.DataGridView dataGridView1Teams;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}