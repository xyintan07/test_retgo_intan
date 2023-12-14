namespace Test_Retgo___Intan
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            input_username = new TextBox();
            label4 = new Label();
            input_password = new TextBox();
            button_login = new Button();
            button_register_pindah = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(3, 10, 3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 0);
            label1.Size = new Size(309, 46);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // input_username
            // 
            input_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input_username.Location = new Point(85, 49);
            input_username.Name = "input_username";
            input_username.Size = new Size(212, 23);
            input_username.TabIndex = 3;
            input_username.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // input_password
            // 
            input_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input_password.Location = new Point(85, 78);
            input_password.Name = "input_password";
            input_password.Size = new Size(212, 23);
            input_password.TabIndex = 5;
            input_password.TextChanged += input_password_TextChanged;
            // 
            // button_login
            // 
            button_login.Enabled = false;
            button_login.Location = new Point(222, 107);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 6;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_register_pindah
            // 
            button_register_pindah.Location = new Point(141, 107);
            button_register_pindah.Name = "button_register_pindah";
            button_register_pindah.Size = new Size(75, 23);
            button_register_pindah.TabIndex = 7;
            button_register_pindah.Text = "Register";
            button_register_pindah.UseVisualStyleBackColor = true;
            button_register_pindah.Click += button_register_pindah_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 144);
            Controls.Add(button_register_pindah);
            Controls.Add(button_login);
            Controls.Add(input_password);
            Controls.Add(label4);
            Controls.Add(input_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "Form Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox input_username;
        private Label label4;
        private TextBox input_password;
        private Button button_login;
        private Button button_register_pindah;
    }
}