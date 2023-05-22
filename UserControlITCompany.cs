using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCompanyList
{
    public partial class UserControlITCompany : UserControl
    {
        public UserControlITCompany()
        {
            InitializeComponent();
        }
        public UserControlITCompany(DataRow dr) : this()
        {
            this.label1.Text = dr[1].ToString();
            this.label2.Text = dr[2].ToString();
            this.label3.Text = dr[3].ToString();
            if(dr[4].ToString() != "")
            {
                this.label4.Text = dr[4].ToString();
            }
            else
            {
                this.label4.Text = "*******";
            }
        }
        public UserControlITCompany(string name, string number, string city, string lead) : this()
        {
            this.label1.Text = name;
            this.label2.Text = number;
            this.label3.Text = city;
            this.label4.Text = lead;
        }
    }
}
