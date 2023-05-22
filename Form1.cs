using System;
using System.Windows.Forms;

namespace ITCompanyList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AdminForm adminForm = new AdminForm();
            //adminForm.ShowDialog();
            UserForm userForm = new UserForm();
            userForm.ShowDialog();

            this.Close();
        }
    }
}
