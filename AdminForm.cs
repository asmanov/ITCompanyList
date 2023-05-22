using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITCompanyList
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ukrITCompanyDBDataSet.ITCompany' table. You can move, or remove it, as needed.
            this.iTCompanyTableAdapter.Fill(this.ukrITCompanyDBDataSet.ITCompany);
        }

        private void AdminForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this.iTCompanyTableAdapter.Update(this.ukrITCompanyDBDataSet.ITCompany);
            
        }
    }
}
