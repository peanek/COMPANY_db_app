using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class TeamsForm : Form
    {
        string connectionStringToDb = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\COMPANY_db_app\COMPANY_db_app\COMPANY_db_app\bin\Debug\DB_COMPANY.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlConnection connection;
        SqlCommandBuilder commandBuilder;
        string selectrionStarStatement = "SELECT * FROM teams";
        SqlCommand command;
        public TeamsForm()
        {
            InitializeComponent();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
