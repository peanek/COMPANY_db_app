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
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2MiddleNane = new System.Windows.Forms.TextBox();
            this.label2MiddleName = new System.Windows.Forms.Label();
            this.textBox3LastName = new System.Windows.Forms.TextBox();
            this.label3LastName = new System.Windows.Forms.Label();
            this.textBox4EmailAddress = new System.Windows.Forms.TextBox();
            this.label4EmailAddress = new System.Windows.Forms.Label();
            this.label5TeamNo = new System.Windows.Forms.Label();
            this.panelWithVariables = new System.Windows.Forms.Panel();
            this.textBox6TeamNo = new System.Windows.Forms.TextBox();
            this.textBox5SearchBox = new System.Windows.Forms.TextBox();
            this.label6SearchEmplyee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1New = new System.Windows.Forms.Button();
            this.button2Edit = new System.Windows.Forms.Button();
            this.button3Cancel = new System.Windows.Forms.Button();
            this.button4Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.panelWithVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1FirstName
            // 
            this.label1FirstName.AutoSize = true;
            this.label1FirstName.Location = new System.Drawing.Point(14, 12);
            this.label1FirstName.Name = "label1FirstName";
            this.label1FirstName.Size = new System.Drawing.Size(55, 13);
            this.label1FirstName.TabIndex = 0;
            this.label1FirstName.Text = "First name";
            // 
            // textBox1FirstName
            // 
            this.textBox1FirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.textBox1FirstName.Location = new System.Drawing.Point(97, 9);
            this.textBox1FirstName.Name = "textBox1FirstName";
            this.textBox1FirstName.Size = new System.Drawing.Size(171, 20);
            this.textBox1FirstName.TabIndex = 1;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(COMPANY_db_app.employees);
            // 
            // textBox2MiddleNane
            // 
            this.textBox2MiddleNane.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Middlename", true));
            this.textBox2MiddleNane.Location = new System.Drawing.Point(97, 35);
            this.textBox2MiddleNane.Name = "textBox2MiddleNane";
            this.textBox2MiddleNane.Size = new System.Drawing.Size(171, 20);
            this.textBox2MiddleNane.TabIndex = 3;
            // 
            // label2MiddleName
            // 
            this.label2MiddleName.AutoSize = true;
            this.label2MiddleName.Location = new System.Drawing.Point(14, 38);
            this.label2MiddleName.Name = "label2MiddleName";
            this.label2MiddleName.Size = new System.Drawing.Size(67, 13);
            this.label2MiddleName.TabIndex = 2;
            this.label2MiddleName.Text = "Middle name";
            // 
            // textBox3LastName
            // 
            this.textBox3LastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.textBox3LastName.Location = new System.Drawing.Point(97, 61);
            this.textBox3LastName.Name = "textBox3LastName";
            this.textBox3LastName.Size = new System.Drawing.Size(171, 20);
            this.textBox3LastName.TabIndex = 5;
            // 
            // label3LastName
            // 
            this.label3LastName.AutoSize = true;
            this.label3LastName.Location = new System.Drawing.Point(14, 64);
            this.label3LastName.Name = "label3LastName";
            this.label3LastName.Size = new System.Drawing.Size(56, 13);
            this.label3LastName.TabIndex = 4;
            this.label3LastName.Text = "Last name";
            // 
            // textBox4EmailAddress
            // 
            this.textBox4EmailAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Email", true));
            this.textBox4EmailAddress.Location = new System.Drawing.Point(97, 87);
            this.textBox4EmailAddress.Name = "textBox4EmailAddress";
            this.textBox4EmailAddress.Size = new System.Drawing.Size(171, 20);
            this.textBox4EmailAddress.TabIndex = 7;
            // 
            // label4EmailAddress
            // 
            this.label4EmailAddress.AutoSize = true;
            this.label4EmailAddress.Location = new System.Drawing.Point(14, 90);
            this.label4EmailAddress.Name = "label4EmailAddress";
            this.label4EmailAddress.Size = new System.Drawing.Size(77, 13);
            this.label4EmailAddress.TabIndex = 6;
            this.label4EmailAddress.Text = "Email addresss";
            // 
            // label5TeamNo
            // 
            this.label5TeamNo.AutoSize = true;
            this.label5TeamNo.Location = new System.Drawing.Point(14, 116);
            this.label5TeamNo.Name = "label5TeamNo";
            this.label5TeamNo.Size = new System.Drawing.Size(52, 13);
            this.label5TeamNo.TabIndex = 8;
            this.label5TeamNo.Text = "Team no.";
            // 
            // panelWithVariables
            // 
            this.panelWithVariables.Controls.Add(this.textBox6TeamNo);
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
            this.panelWithVariables.Size = new System.Drawing.Size(502, 144);
            this.panelWithVariables.TabIndex = 10;
            // 
            // textBox6TeamNo
            // 
            this.textBox6TeamNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Team_Id", true));
            this.textBox6TeamNo.Location = new System.Drawing.Point(97, 113);
            this.textBox6TeamNo.Name = "textBox6TeamNo";
            this.textBox6TeamNo.Size = new System.Drawing.Size(171, 20);
            this.textBox6TeamNo.TabIndex = 12;
            // 
            // textBox5SearchBox
            // 
            this.textBox5SearchBox.Location = new System.Drawing.Point(134, 162);
            this.textBox5SearchBox.Name = "textBox5SearchBox";
            this.textBox5SearchBox.Size = new System.Drawing.Size(377, 20);
            this.textBox5SearchBox.TabIndex = 11;
            this.textBox5SearchBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6SearchEmplyee
            // 
            this.label6SearchEmplyee.AutoSize = true;
            this.label6SearchEmplyee.Location = new System.Drawing.Point(26, 165);
            this.label6SearchEmplyee.Name = "label6SearchEmplyee";
            this.label6SearchEmplyee.Size = new System.Drawing.Size(90, 13);
            this.label6SearchEmplyee.TabIndex = 10;
            this.label6SearchEmplyee.Text = "Search Employee";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.programBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1New
            // 
            this.button1New.Location = new System.Drawing.Point(191, 349);
            this.button1New.Name = "button1New";
            this.button1New.Size = new System.Drawing.Size(75, 23);
            this.button1New.TabIndex = 12;
            this.button1New.Text = "New";
            this.button1New.UseVisualStyleBackColor = true;
            this.button1New.Click += new System.EventHandler(this.button1New_Click);
            // 
            // button2Edit
            // 
            this.button2Edit.Location = new System.Drawing.Point(272, 349);
            this.button2Edit.Name = "button2Edit";
            this.button2Edit.Size = new System.Drawing.Size(75, 23);
            this.button2Edit.TabIndex = 13;
            this.button2Edit.Text = "Edit";
            this.button2Edit.UseVisualStyleBackColor = true;
            this.button2Edit.Click += new System.EventHandler(this.button2Edit_Click);
            // 
            // button3Cancel
            // 
            this.button3Cancel.Location = new System.Drawing.Point(434, 349);
            this.button3Cancel.Name = "button3Cancel";
            this.button3Cancel.Size = new System.Drawing.Size(75, 23);
            this.button3Cancel.TabIndex = 14;
            this.button3Cancel.Text = "Cancel";
            this.button3Cancel.UseVisualStyleBackColor = true;
            this.button3Cancel.Click += new System.EventHandler(this.button4Cancel_Click);
            // 
            // button4Save
            // 
            this.button4Save.Location = new System.Drawing.Point(353, 349);
            this.button4Save.Name = "button4Save";
            this.button4Save.Size = new System.Drawing.Size(75, 23);
            this.button4Save.TabIndex = 15;
            this.button4Save.Text = "Save";
            this.button4Save.UseVisualStyleBackColor = true;
            this.button4Save.Click += new System.EventHandler(this.button3Save_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 381);
            this.Controls.Add(this.button4Save);
            this.Controls.Add(this.textBox5SearchBox);
            this.Controls.Add(this.button3Cancel);
            this.Controls.Add(this.label6SearchEmplyee);
            this.Controls.Add(this.button2Edit);
            this.Controls.Add(this.button1New);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelWithVariables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.Text = "Employees Edit";
            this.Load += new System.EventHandler(this.EmplyeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.panelWithVariables.ResumeLayout(false);
            this.panelWithVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.Button button1New;
        private System.Windows.Forms.Button button2Edit;
        private System.Windows.Forms.Button button3Cancel;
        private System.Windows.Forms.Button button4Save;
        private System.Windows.Forms.TextBox textBox6TeamNo;
        private System.Windows.Forms.BindingSource employeesBindingSource;
    }
}