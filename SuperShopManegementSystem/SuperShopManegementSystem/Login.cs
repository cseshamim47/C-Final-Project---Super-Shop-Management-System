using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManegementSystem
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            string query = "select * from UserInfo where UserName = '" + this.txtLoginId.Text + "' and Password = '" + this.txtLoginPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            if (ds.Tables[0].Rows.Count == 1) MessageBox.Show("logged in");
            else MessageBox.Show("incorrect cred");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string query = "select * from UserInfo where UserName = '" + this.txtLoginId.Text + "' and Password = '" + this.txtLoginPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            if (ds.Tables[0].Rows.Count == 1) MessageBox.Show("logged in");
            else MessageBox.Show("incorrect cred");
        }
    }
}
