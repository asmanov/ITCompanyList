using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITCompanyList
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.iTCompanyTableAdapter.Fill(this.ukrITCompanyDBDataSet1.ITCompany);
            System.Data.DataTable dataTable = this.ukrITCompanyDBDataSet1.Tables[0];
            UserControlITCompany userControlITCompanytitle = new UserControlITCompany("Название", "Кол-во сотрудников", "Локация офисов", "Руководитель");
            this.flowLayoutPanel1.Controls.Add(userControlITCompanytitle);
            foreach (DataRow dr in dataTable.Rows)
            {
                UserControlITCompany userControlITCompany = new UserControlITCompany(dr);
                this.flowLayoutPanel1.Controls.Add(userControlITCompany);
                
            }

        }
    }
}
