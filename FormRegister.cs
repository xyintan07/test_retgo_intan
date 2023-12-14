using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Retgo___Intan
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void ValidateRegisterButton()
        {
            button_register.Enabled = !(input_name.Text == "" || input_username.Text == "" || input_password.Text == "");
        }

        private void button_login_pindah_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void input_name_TextChanged(object sender, EventArgs e)
        {
            ValidateRegisterButton();
        }

        private void input_username_TextChanged(object sender, EventArgs e)
        {
            ValidateRegisterButton();
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {
            ValidateRegisterButton();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            button_register.Enabled = false;

            Database db = new Database();
            bool auth_success = db.RegisterAnggota(input_name.Text, input_username.Text, input_password.Text);

            if (auth_success)
            {
                MessageBox.Show("Register Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Unexpected Error, We can't register right now.");
            }

            button_register.Enabled = true;
        }
    }
}
