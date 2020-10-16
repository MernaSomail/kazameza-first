using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kazameza
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            this.EnableGlass = false;//The essential,
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void login_btn_Click(object sender, EventArgs e)
        {
            Model2 mod = new Model2();
            var check = mod.Logins.FirstOrDefault(x => x.Username == username_txt.Text && x.Password == password_txt.Text);
            if (check != null)
            {
                Products p = new Products();
                p.Show();
            }
            else
            {
                msgerror.Text = "username or password wrong";

            }


        }
    }
}
