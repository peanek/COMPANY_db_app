using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
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
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

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
            foreach (DbEntityEntry entry in database.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added:
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        break;
                    default:
                        break;
                }
            }

            DialogResult message = MessageBox.Show("Do you want to close employee editor?", "Question:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
