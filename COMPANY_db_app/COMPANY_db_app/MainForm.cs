using System;
using System.Windows.Forms;

namespace COMPANY_db_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            MessageBox.Show("Copyright by\nPrzemyslaw Peczkowski."); 
        }

#pragma warning disable IDE1006 // Naming Styles
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            EmployeesForm form = new EmployeesForm
            {
                MdiParent = this
            };
            form.Show();


        }

#pragma warning disable IDE1006 // Naming Styles
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            LayoutMdi(MdiLayout.Cascade);
        }

#pragma warning disable IDE1006 // Naming Styles
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

#pragma warning disable IDE1006 // Naming Styles
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

#pragma warning disable IDE1006 // Naming Styles
        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            TeamsForm form = new TeamsForm
            {
                MdiParent = this
            };
            form.Show();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            ProjectsForm form = new ProjectsForm
            {
                MdiParent = this
            };
            form.Show();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void workItemsToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            WorkItemsForm form = new WorkItemsForm
            {
                MdiParent = this
            };
            form.Show();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void toolStripMenuItem2Exit_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            this.Close();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void projectCooperationToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            ProjectAssignment form = new ProjectAssignment
            {
                MdiParent = this
            };
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
