using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

using System.Linq;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class EmployeesForm : Form
    {
        string connectionStringToDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\COMPANY_db_app\COMPANY_db_app\COMPANY_db_app\bin\Debug\DB_COMPANY.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection connection;
        SqlCommandBuilder commandBuilder;
        CompanyDatabaseEntity database;
        string selectrionStarStatement = "SELECT * FROM employees";
        DataGridViewRow row;
        SqlCommand command;

        public EmployeesForm()
        {
            InitializeComponent();
            
        }



        private void EmplyeesForm_Load(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = false;
            button1Add.Visible = false;
            //To rewrite ?
            //database = new CompanyDatabaseEntity();
            //employeesBindingSource.DataSource = database.employees.ToList();
            dataGridView1EmployessGrid.DataSource = employeesBindingSource;
            GetData(selectrionStarStatement);
            FillComboBox();

        }

        private void FillComboBox()
        {
            connection = new SqlConnection(connectionStringToDb);
            try
            {
                comboBox2TeamNo.Items.Clear();
                connection.Open();
                string querySelectTeamsId = "SELECT id FROM teams";

                // This below was fixed with only one SqlCommand line -> can be deleted 
                //SqlCommand command = connection.CreateCommand();
                //command.CommandType = CommandType.Text;
                //command.CommandText = ;
                //command.ExecuteNonQuery();
                SqlCommand command = new SqlCommand(querySelectTeamsId, connection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)
                {
                    comboBox2TeamNo.Items.Add(item["id"].ToString());
                }
                comboBox2TeamNo.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void GetData(string selectCommand)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connectionStringToDb);
                table = new DataTable();

                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                employeesBindingSource.DataSource = table;
                //dataGridView1EmployessGrid.Columns[0].ReadOnly = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            try
            {
                
                textBox1FirstName.Focus();
                //employees employee = new employees();
                //employeesBindingSource.Add(employee);
                //employeesBindingSource.MoveLast();
                string queryInsert = @"INSERT INTO [dbo].[employees]([FirstName],[Middlename],[LastName],[Email],[Team_Id])
                                VALUES(@FirstName, @MiddleName, @LastName, @Email, @TeamID)";
                using (connection = new SqlConnection(connectionStringToDb))
                {
                    connection.Open();
                    command = new SqlCommand(queryInsert, connection);
                    command.Parameters.AddWithValue("@FirstName", textBox1FirstName.Text);
                    command.Parameters.AddWithValue("@MiddleName", textBox2MiddleNane.Text);
                    command.Parameters.AddWithValue("@LastName", textBox3LastName.Text);
                    command.Parameters.AddWithValue("@Email", textBox4EmailAddress.Text);
                    command.Parameters.AddWithValue("@TeamID", comboBox2TeamNo.Text);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GetData(selectrionStarStatement);
                dataGridView1EmployessGrid.Update();
                connection.Close();
            }
        }

        private void button2Edit_Click(object sender, EventArgs e)
        {
            //panelWithVariables.Enabled = true;
            //textBox1FirstName.Focus();
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                employeesBindingSource.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Row has been updated!","Success",MessageBoxButtons.OK,MessageBoxIcon.None);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
        
        
        //private void button3Save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        employeesBindingSource.EndEdit();
        //        database.SaveChangesAsync();
        //        panelWithVariables.Enabled = false;
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message,"Error message",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //        employeesBindingSource.ResetBindings(false);
        //    }
        //}
        private void button4Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
            //panelWithVariables.Enabled = false;
            //employeesBindingSource.ResetBindings(false);
            //foreach (var entry in database.ChangeTracker.Entries())
            //{
            //    switch (entry.State)
            //    {
            //        case EntityState.Added:
            //            entry.State = EntityState.Detached;
            //            break;
            //        case EntityState.Modified:
            //            entry.State = EntityState.Unchanged;
            //            break;
            //        case EntityState.Deleted:
            //            entry.Reload();
            //            break;
                    


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


            //    }
            //}

            //DialogResult message = MessageBox.Show("Do you want to close employee editor?", "Question:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (message == DialogResult.Yes)
            //{
            //    this.Close();
            //}

        }

        private void textBox5SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                SearchLogic(e);
        }

        private void SearchLogic(EventArgs e)
        {
                if (comboBox1SearchItem.Text == "")
                {
                    MessageBox.Show("Please select search property on left ! IT is empty !","Search error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    
                }
            else
            {
                if (string.IsNullOrEmpty(textBox5SearchBox.Text))
                {
                    dataGridView1EmployessGrid.DataSource = employeesBindingSource;
                    comboBox1SearchItem.Text = "";
                    GetData(selectrionStarStatement);
                }
                else
                {
                    switch (comboBox1SearchItem.SelectedItem.ToString())
                    {
                        case "First Name":
                            try
                            {
                                GetData($"SELECT * FROM employees WHERE lower(FirstName) like '%{textBox5SearchBox.Text.ToLower()}%'");
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case "Last Name":
                            try
                            {
                                GetData($"SELECT * FROM employees WHERE lower(LastName) like '%{textBox5SearchBox.Text.ToLower()}%'");
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;

                        case "Email":
                            try
                            {
                                GetData($"SELECT * FROM employees WHERE lower(Email) like '%{textBox5SearchBox.Text.ToLower()}%'");
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    }
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

        private void checkBox1Editing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1Editing.Checked)
            {
                panelWithVariables.Enabled = true;
                button1Add.Visible = true;
            }
            else
            {
                panelWithVariables.Enabled = false;
                button1Add.Visible = false;
            } 
        }

        private void button5Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionStringToDb);
            row = new DataGridViewRow();
            row = dataGridView1EmployessGrid.CurrentCell.OwningRow;
            string idValue = row.Cells[0].Value.ToString();
            string fNameValue = row.Cells[1].Value.ToString();
            string lNameValue = row.Cells[3].Value.ToString();

            DialogResult result = MessageBox.Show($"Do you really want to delete user of ID {idValue}, of Name : {fNameValue} {lNameValue} ?","Delete?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = $"DELETE FROM employees WHERE id = '{idValue}'";
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    GetData(selectrionStarStatement);
                    dataGridView1EmployessGrid.Update();
                    connection.Close();
                }
                
            }
            

            //string columns = dataGridView1EmployessGrid.Columns.IndexOf('0').ToString();
            //MessageBox.Show(columns);

            //row = dataGridView1EmployessGrid.CurrentCell.OwningRow;
            //string rowIdNum = row.Cells["id"].Value.ToString();
            //string fName = row.Cells["FisrNameDataGridViewTextBoxColumn"].Value.ToString();
            //string lName = row.Cells["LastNameDataGridViewTextBoxColumn"].Value.ToString();
            //DialogResult result = MessageBox.Show($"Really want to delete {rowIdNum} Name : {fName}{lName}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{

            //}
        }

        private void button8Search_Click(object sender, EventArgs e)
        {
            SearchLogic(e);
        }
    }
}
