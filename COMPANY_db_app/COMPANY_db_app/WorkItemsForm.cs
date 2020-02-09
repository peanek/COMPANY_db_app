using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class WorkItemsForm : Form
    {
        string connectionStringToDb = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_COMPANY;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection connection;
        SqlCommandBuilder commandBuilder;
        string selectStarQuery = "SELECT * FROM work_items";
        DataGridViewRow row;
        SqlCommand command;
        public WorkItemsForm()
        {
            InitializeComponent();
        }

        private void WorkItemsForm_Load(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = false;
            button4Add.Enabled = false;
            //To rewrite ?
            //database = new CompanyDatabaseEntity();
            //employeesBindingSource.DataSource = database.employees.ToList();
            dataGridView1WorkItems.DataSource = workitemsBindingSource;
            GetData(selectStarQuery);
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            connection = new SqlConnection(connectionStringToDb);
            try
            {
                comboBox1Projectid.Items.Clear();
                comboBox2Employeeid.Items.Clear();

                connection.Open();

                string querySelectProjectsId = "SELECT Id FROM projects";
                // This below was fixed with only one SqlCommand line -> can be deleted 
                //SqlCommand command = connection.CreateCommand();
                //command.CommandType = CommandType.Text;
                //command.CommandText = ;
                //command.ExecuteNonQuery();
                command = new SqlCommand(querySelectProjectsId, connection);
                DataTable dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                foreach (DataRow item in dataTable.Rows)
                {
                    comboBox1Projectid.Items.Add(item["id"].ToString());
                }
                comboBox1Projectid.SelectedIndex = 0;
                //
                string querySelectIdEmployee = "SELECT Id FROM employees";
                command = new SqlCommand(querySelectIdEmployee, connection);
                dataAdapter = new SqlDataAdapter(command);
                DataTable dataTableEmployeeID = new DataTable();
                dataAdapter.Fill(dataTableEmployeeID);
                foreach (DataRow item in dataTableEmployeeID.Rows)
                {
                    comboBox2Employeeid.Items.Add(item["id"].ToString());
                }
                comboBox2Employeeid.SelectedIndex = 0;
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
                workitemsBindingSource.DataSource = table;
                dataGridView1WorkItems.Columns[0].ReadOnly = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1AddEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1AddEnabled.Checked)
            {
                button4Add.Enabled = true;
                panelWithVariables.Enabled = true;
            }
            else
            {
                button4Add.Enabled = false;
                panelWithVariables.Enabled = false;
            }
        }

        private void button4Add_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1Name.Focus();
                string queryInsert = @"INSERT INTO [dbo].[work_items]
           ([Name]
           ,[Description]
           ,[Project_Id]
           ,[Employee_Id]
           ,[DateCreated]
           ,[DateStarted]
           ,[DateFinished]
           ,[DateDue])
     VALUES
           (@Name
           ,@Description
           ,@ProjectId
           ,@EmplyeeId
           ,CURRENT_TIMESTAMP
           ,NULL
           ,NULL
           ,@DateDue)";
                using (connection = new SqlConnection(connectionStringToDb))
                {
                    connection.Open();
                    command = new SqlCommand(queryInsert, connection);
                    command.Parameters.AddWithValue("@Name", textBox1Name.Text);
                    command.Parameters.AddWithValue("@Description", richTextBox1Description.Text);
                    command.Parameters.AddWithValue("@ProjectId", comboBox1Projectid.Text);
                    command.Parameters.AddWithValue("@EmplyeeId", comboBox2Employeeid.Text);
                    command.Parameters.AddWithValue("@DateDue", dateTimePicker1DueDate.Value.Date);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridView1WorkItems.Update();
                GetData(selectStarQuery);
                connection.Close();
            }
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                workitemsBindingSource.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Row has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2Delete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionStringToDb);
            row = new DataGridViewRow();
            row = dataGridView1WorkItems.CurrentCell.OwningRow;
            string idValue = row.Cells[0].Value.ToString();
            string nNameValue = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show($"Do you really want to delete team of ID : {idValue} and Name : {nNameValue} ?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string queryDelete = $"DELETE FROM work_items where id = {idValue}";
                    connection.Open();
                    command = new SqlCommand(queryDelete, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    GetData(selectStarQuery);
                    dataGridView1WorkItems.Update();
                    connection.Close();
                }
            }
        }

        private void button1Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            SearchLogic(e);
        }

        private void SearchLogic(EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1SearchBox.Text))
            {
                dataGridView1WorkItems.DataSource = workitemsBindingSource;
                GetData(selectStarQuery);
            }
            else
            {
                try
                {
                    GetData($"SELECT * FROM work_items WHERE lower(Name) like '%{textBox1SearchBox.Text.ToLower()}%'");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }

        private void textBox1SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchLogic(e);
            }
        }
    }
    }
