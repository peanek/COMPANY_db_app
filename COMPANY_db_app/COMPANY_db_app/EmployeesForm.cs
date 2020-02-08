using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class EmployeesForm : Form
    {
        CompanyDatabaseEntity database;
        public EmployeesForm()
        {
            InitializeComponent();
        }



        private void EmplyeesForm_Load(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = false;

            database = new CompanyDatabaseEntity();
            employeesBindingSource.DataSource = database.employees.ToList();
        }

        private void button1New_Click(object sender, EventArgs e)
        {
            try
            {
                panelWithVariables.Enabled = true;
                textBox1FirstName.Focus();
                employees employee = new employees();
                employeesBindingSource.Add(employee);
                employeesBindingSource.MoveLast();

            }
            catch (Exception ecxeption)
            {
                MessageBox.Show(ecxeption.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void button2Edit_Click(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = true;
            textBox1FirstName.Focus();
        }

        private void button3Save_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.EndEdit();
                database.SaveChangesAsync();
                panelWithVariables.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
                throw;
            }
        }
        private void button4Cancel_Click(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = false;
            employeesBindingSource.ResetBindings(false);
            foreach (var entry in database.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    


                    //case System.Data.Entity.EntityState.Detached:
                    //    break;
                    //case System.Data.Entity.EntityState.Unchanged:
                    //    break;
                    //case System.Data.Entity.EntityState.Added:
                    //    break;
                    //case System.Data.Entity.EntityState.Deleted:
                    //    break;
                    //case System.Data.Entity.EntityState.Modified:
                    //    break;
                    //default:
                    //    break;


                }
            }

            DialogResult message = MessageBox.Show("Do you want to close employee editor?", "Question:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void textBox5SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (string.IsNullOrEmpty(textBox5SearchBox.Text))
                {
                    dataGridView1EmployessGrid.DataSource = employeesBindingSource;

                }
                else
                {
                    var query = from o in employeesBindingSource.DataSource as List<employees>
                                where o.FirstName.Contains(textBox5SearchBox.Text) || o.Middlename.Contains(textBox5SearchBox.Text) ||
                                o.LastName.Contains(textBox5SearchBox.Text) || o.Email.Contains(textBox5SearchBox.Text) ||
                                o.Team_Id.Equals(textBox5SearchBox.Text)
                                select o;
                    dataGridView1EmployessGrid.DataSource = query;    



                }
            }
        }

        private void dataGridView1EmployessGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure to delete this row??","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes);
                {
                    database.employees.Remove(employeesBindingSource.Current as employees);
                    employeesBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
