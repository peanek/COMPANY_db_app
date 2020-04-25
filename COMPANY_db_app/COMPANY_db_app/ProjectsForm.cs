using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class ProjectsForm : Form
    {
        string connectionStringToDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB_COMPANY.mdf;Initial Catalog=DB_COMPANY;Integrated Security=True";
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection connection;
        SqlCommandBuilder commandBuilder;
        string selectStarQuery = "SELECT * FROM projects";
        DataGridViewRow row;
        SqlCommand command;
        public ProjectsForm()
        {
            InitializeComponent();
        }

        private void checkBox1AddProject_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1AddProject.Checked)
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

        private void button4Add_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1Name.Focus();
                //employees employee = new employees();
                //employeesBindingSource.Add(employee);
                //employeesBindingSource.MoveLast();
                string queryInsert = @"INSERT INTO[dbo].[projects]
           ([Name]
           ,[ProjectManager_Id]
           ,[DateStart]
           ,[DateDue])
     VALUES
           (@Name
           ,@ProjectManager_Id
           ,CURRENT_TIMESTAMP
           ,@DateDue)";
                    
                    //@"INSERT INTO [dbo].[employees]([FirstName],[Middlename],[LastName],[Email],[Team_Id])
                    //            VALUES(@FirstName, @MiddleName, @LastName, @Email, @TeamID)";
                using (connection = new SqlConnection(connectionStringToDb))
                {
                    connection.Open();
                    command = new SqlCommand(queryInsert, connection);
                    command.Parameters.AddWithValue("@Name", textBox1Name.Text);
                    command.Parameters.AddWithValue("@ProjectManager_Id", textBox2Manager.Text);
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
                GetData(selectStarQuery);
                dataGridView1projects.Update();
                connection.Close();
            }
        }

        private void button3Edit_Click(object sender, EventArgs e)
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                projectsBindingSource.EndEdit();
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
            row = dataGridView1projects.CurrentCell.OwningRow;
            string idValue = row.Cells[0].Value.ToString();
            string nNameValue = row.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show($"Do you really want to delete team of ID : {idValue} and Name : {nNameValue} ?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string queryDelete = $"DELETE FROM teams where id = {idValue}";
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
                    dataGridView1projects.Update();
                    connection.Close();
                }
            }
        }

        private void button1Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectsForm_Load(object sender, EventArgs e)
        {
            panelWithVariables.Enabled = false;
            button1Add.Enabled = false;
            //To rewrite ?
            //database = new CompanyDatabaseEntity();
            //employeesBindingSource.DataSource = database.employees.ToList();
            dataGridView1projects.DataSource = projectsBindingSource;
            GetData(selectStarQuery);
        }

        private void GetData(string selectStarQuery)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectStarQuery, connectionStringToDb);
                table = new DataTable();

                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                projectsBindingSource.DataSource = table;
                dataGridView1projects.Columns[0].ReadOnly = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1Search_Click(object sender, EventArgs e)
        {
            SearchLogic(e);
        }

        private void textBox3SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchLogic(e);
            }
        }

        private void SearchLogic(EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3SearchBox.Text))
            {
                dataGridView1projects.DataSource = projectsBindingSource;
                GetData(selectStarQuery);
            }
            else
            {
                try
                {
                    GetData($"SELECT * FROM projects WHERE lower(Name) like '%{textBox3SearchBox.Text.ToLower()}%' or lower(ProjectManager_ID) like '%{textBox3SearchBox.Text.ToLower()}%'");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
