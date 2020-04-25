using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class ProjectAssignment : Form
    {
        string connectionStringToDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB_COMPANY.mdf;Initial Catalog=DB_COMPANY;Integrated Security=True";
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection connection;
        SqlCommandBuilder commandBuilder;
        string selectStarQuery = "SELECT * FROM project_cooperation";
        SqlCommand command;
        DataGridViewRow row;
        public ProjectAssignment()
        {
            InitializeComponent();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (checkBox1Add.Checked)
            {
                button4Add.Enabled = true;
                panel1Variables.Enabled = true;
            }
            else
            {
                button4Add.Enabled = false;
                panel1Variables.Enabled = false;
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button4Add_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            try
            {
                comboBox1ProjectId.Focus();
                string queryInsert = @"INSERT INTO [dbo].[project_cooperation]
           ([Project_Id]
           ,[Team_Id]
           ,[DateAssigned])
     VALUES
           (@ProjectId
           ,@TeamId
           ,CURRENT_TIMESTAMP)";
                using (connection = new SqlConnection(connectionStringToDb))
                {
                    connection.Open();
                    command = new SqlCommand(queryInsert, connection);
                    command.Parameters.AddWithValue("@ProjectId", comboBox1ProjectId.Text);
                    command.Parameters.AddWithValue("@TeamId", comboBox2TeamId.Text);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridView1ProjectCooperation.Update();
                GetData(selectStarQuery);
                connection.Close();
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button3Edit_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                projectcooperationBindingSource.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Row has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button2Delete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            connection = new SqlConnection(connectionStringToDb);
            row = new DataGridViewRow();
            row = dataGridView1ProjectCooperation.CurrentCell.OwningRow;
            string idValue = row.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show($"Do you really want to delete project assignemnt of ID : {idValue} ?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string queryDelete = $"DELETE FROM project_cooperation where id = {idValue}";
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
                    dataGridView1ProjectCooperation.Update();
                    connection.Close();
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button1Cancel_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Close();
        }

        private void ProjectAssignment_Load(object sender, EventArgs e)
        {
            button4Add.Enabled = false;
            panel1Variables.Enabled = false;

            dataGridView1ProjectCooperation.DataSource = projectcooperationBindingSource;
            GetData(selectStarQuery);
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            connection = new SqlConnection(connectionStringToDb);
            try
            {
                comboBox1ProjectId.Items.Clear();
                comboBox2TeamId.Items.Clear();
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
                    comboBox1ProjectId.Items.Add(item["id"].ToString());
                }
                comboBox1ProjectId.SelectedIndex = 0;
                //
                string querySelectIdEmployee = "SELECT Id FROM teams";
                command = new SqlCommand(querySelectIdEmployee, connection);
                dataAdapter = new SqlDataAdapter(command);
                DataTable dataTableEmployeeID = new DataTable();
                dataAdapter.Fill(dataTableEmployeeID);
                foreach (DataRow item in dataTableEmployeeID.Rows)
                {
                    comboBox2TeamId.Items.Add(item["id"].ToString());
                }
                comboBox2TeamId.SelectedIndex = 0;
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
                dataAdapter.Fill(table);
                projectcooperationBindingSource.DataSource = table;
                dataGridView1ProjectCooperation.Columns[0].ReadOnly = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
