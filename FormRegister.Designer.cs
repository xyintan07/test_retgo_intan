namespace Test_Retgo___Intan
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_login_pindah = new Button();
            button_register = new Button();
            input_password = new TextBox();
            label4 = new Label();
            input_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            input_name = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_login_pindah
            // 
            button_login_pindah.Location = new Point(141, 167);
            button_login_pindah.Name = "button_login_pindah";
            button_login_pindah.Size = new Size(75, 23);
            button_login_pindah.TabIndex = 14;
            button_login_pindah.Text = "Close";
            button_login_pindah.UseVisualStyleBackColor = true;
            button_login_pindah.Click += button_login_pindah_Click;
            // 
            // button_register
            // 
            button_register.Enabled = false;
            button_register.Location = new Point(222, 167);
            button_register.Name = "button_register";
            button_register.Size = new Size(75, 23);
            button_register.TabIndex = 13;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // input_password
            // 
            input_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input_password.Location = new Point(85, 109);
            input_password.Name = "input_password";
            input_password.Size = new Size(212, 23);
            input_password.TabIndex = 12;
            input_password.TextChanged += input_password_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // input_username
            // 
            input_username.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input_username.Location = new Point(85, 80);
            input_username.Name = "input_username";
            input_username.Size = new Size(212, 23);
            input_username.TabIndex = 10;
            input_username.TextChanged += input_username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Username";
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
            label1.TabIndex = 8;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // input_name
            // 
            input_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input_name.Location = new Point(85, 51);
            input_name.Name = "input_name";
            input_name.Size = new Size(212, 23);
            input_name.TabIndex = 16;
            input_name.TextChanged += input_name_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 15;
            label3.Text = "Name";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 202);
            Controls.Add(input_name);
            Controls.Add(label3);
            Controls.Add(button_login_pindah);
            Controls.Add(button_register);
            Controls.Add(input_password);
            Controls.Add(label4);
            Controls.Add(input_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "Form Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_login_pindah;
        private Button button_register;
        private TextBox input_password;
        private Label label4;
        private TextBox input_username;
        private Label label2;
        private Label label1;
        private TextBox input_name;
        private Label label3;
    }
}