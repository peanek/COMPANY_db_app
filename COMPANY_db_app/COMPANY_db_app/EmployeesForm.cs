using System;
using System.Data;
using System.Data.SqlClient;
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
        string selectStarQuery = "SELECT * FROM employees";
        DataGridViewRow row;
        SqlCommand command;

        public EmployeesForm()
        {
            InitializeComponent();
            
        }

        private void EmplyeesForm_Load(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = false;
            button1Add.Enabled = false;
            //To rewrite ?
            //database = new CompanyDatabaseEntity();
            //employeesBindingSource.DataSource = database.employees.ToList();
            dataGridView1EmployessGrid.DataSource = employeesBindingSource;
            GetData(selectStarQuery);
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

        private void GetData(string selectStarQuery)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectStarQuery, connectionStringToDb);
                table = new DataTable();

                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                employeesBindingSource.DataSource = table;
                dataGridView1EmployessGrid.Columns[0].ReadOnly = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button1Add_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            try
            {
                textBox1FirstName.Focus();
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
                MessageBox.Show("New employee succesfull added !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetData(selectStarQuery);
                dataGridView1EmployessGrid.Update();
                connection.Close();
            }
        }

        private void button2Edit_Click(object sender, EventArgs e)
        {
            //Take actual selected row in DataTable and Update() -> try to -> with values edited
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
        }

#pragma warning disable IDE1006 // Naming Styles
        private void textBox5SearchBox_KeyPress(object sender, KeyPressEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
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
                    GetData(selectStarQuery);
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

#pragma warning disable IDE1006 // Naming Styles
        private void checkBox1Editing_CheckedChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (checkBox1Editing.Checked)
            {
                panelWithVariables.Enabled = true;
                button1Add.Enabled = true;
            }
            else
            {
                panelWithVariables.Enabled = false;
                button1Add.Enabled = false;
            } 
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button5Delete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
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
                    GetData(selectStarQuery);
                    dataGridView1EmployessGrid.Update();
                    connection.Close();
                }
                
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button8Search_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            SearchLogic(e);
        }
    }
}
