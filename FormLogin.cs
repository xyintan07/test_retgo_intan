namespace Test_Retgo___Intan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ValidateLoginButton()
        {
            button_login.Enabled = !(input_username.Text == "" || input_password.Text == "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginButton();
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginButton();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            button_login.Enabled = false;

            Database db = new Database();
            bool auth_success = db.AuthAnggota(input_username.Text, input_password.Text);

            if (auth_success)
            {
                List<DataItem> data_anggota = db.Query("SELECT * FROM anggota WHERE username='"+input_username.Text+"'");

                Form form_profil = new FormProfil(data_anggota[1].value, data_anggota[2].value, data_anggota[3].value);
                form_profil.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username or password!");
            }

            button_login.Enabled = true;
        }

        private void button_register_pindah_Click(object sender, EventArgs e)
        {
            Form formRegister = new FormRegister();
            formRegister.Show();
        }
    }
}