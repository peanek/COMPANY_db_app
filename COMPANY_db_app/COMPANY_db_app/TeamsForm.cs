using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class TeamsForm : Form
    {
        string connectionStringToDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB_COMPANY.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection connection;
        SqlCommandBuilder commandBuilder;
        string selectStarQuery = "SELECT * FROM teams";
        SqlCommand command;
        DataGridViewRow row;
        public TeamsForm()
        {
            InitializeComponent();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            button1Add.Enabled = false;
            panel1Variables.Enabled = false;

            dataGridView1Teams.DataSource = teamsBindingSource;
            GetData(selectStarQuery);
        }

        private void GetData(string selectStarQuery)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectStarQuery, connectionStringToDb);
                table = new DataTable();
                dataAdapter.Fill(table);
                teamsBindingSource.DataSource = table;
                dataGridView1Teams.Columns[0].ReadOnly = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void checkBox1AddOption_CheckedChanged(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (checkBox1AddOption.Checked)
            {
                button1Add.Enabled = true;
                panel1Variables.Enabled = true;
            }
            else
            {
                button1Add.Enabled = false;
                panel1Variables.Enabled = false;
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button1Add_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            try
            {
                textBox1TeamName.Focus();
                string queryInsert = @"INSERT INTO [dbo].[teams] ([Name]) VALUES (@Name)";
                using (connection = new SqlConnection(connectionStringToDb))
                {
                    connection.Open();
                    command = new SqlCommand(queryInsert,connection);
                    command.Parameters.AddWithValue("@Name",textBox1TeamName.Text);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridView1Teams.Update();
                GetData(selectStarQuery);
                connection.Close();
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button2Edit_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            try
            {
                teamsBindingSource.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Row has been updated!","Success",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button3Delete_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            connection = new SqlConnection(connectionStringToDb);
            row = new DataGridViewRow();
            row = dataGridView1Teams.CurrentCell.OwningRow;
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
                    dataGridView1Teams.Update();
                    connection.Close();
                }
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button1Search_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            SearchLogic(e);
        }

        private void SearchLogic(EventArgs e)
        {
                if (string.IsNullOrEmpty(textBox2SearchBox.Text))
                {
                    dataGridView1Teams.DataSource = teamsBindingSource;
                    GetData(selectStarQuery);
                }
                else
                {
                    try
                    {
                    GetData($"SELECT * FROM teams WHERE lower(Name) like '%{textBox2SearchBox.Text.ToLower()}%'");
                    }
                    catch (Exception exception)
                    {
                    MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                            //try
                            //{
                            //    GetData($"SELECT * FROM employees WHERE lower(FirstName) like '%{textBox2SearchBox.Text.ToLower()}%'");
                            //}
                            //catch (Exception exception)
                            //{
                            //    MessageBox.Show(exception.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //}
                }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button4Cancel_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Close();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void textBox2SearchBox_KeyPress(object sender, KeyPressEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                SearchLogic(e);
            }
        }
    }
}
