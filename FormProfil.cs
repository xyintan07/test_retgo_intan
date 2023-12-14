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
    public partial class FormProfil : Form
    {
        public FormProfil(string nama, string username, string bio)
        {
            InitializeComponent();

            label_nama.Text = nama;
            label_username.Text = username;
            label_bio.Text = bio;

            input_nama.Text = nama;
            input_bio.Text = bio;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            Application.Exit();
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.Query("UPDATE anggota SET name='" + input_nama.Text + "', bio='" + input_bio.Text + "' WHERE username='"+label_username.Text+"'");

            Form newUpdate = new FormProfil(input_nama.Text, label_username.Text, input_bio.Text);
            newUpdate.Show();
            this.Hide();
        }
    }
}
