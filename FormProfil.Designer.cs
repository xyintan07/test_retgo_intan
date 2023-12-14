namespace Test_Retgo___Intan
{
    partial class FormProfil
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
            input_nama = new TextBox();
            input_bio = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_simpan = new Button();
            label_nama = new Label();
            label_username = new Label();
            label_bio = new Label();
            SuspendLayout();
            // 
            // input_nama
            // 
            input_nama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            input_nama.Location = new Point(57, 182);
            input_nama.Name = "input_nama";
            input_nama.Size = new Size(266, 23);
            input_nama.TabIndex = 4;
            // 
            // input_bio
            // 
            input_bio.Location = new Point(57, 208);
            input_bio.Name = "input_bio";
            input_bio.Size = new Size(266, 116);
            input_bio.TabIndex = 5;
            input_bio.Text = "";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 156);
            label1.Name = "label1";
            label1.Size = new Size(292, 23);
            label1.TabIndex = 6;
            label1.Text = "--- Control ---";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 7;
            label2.Text = "Bio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Nama";
            // 
            // button_simpan
            // 
            button_simpan.Location = new Point(57, 330);
            button_simpan.Name = "button_simpan";
            button_simpan.Size = new Size(75, 23);
            button_simpan.TabIndex = 9;
            button_simpan.Text = "Simpan";
            button_simpan.UseVisualStyleBackColor = true;
            button_simpan.Click += button_simpan_Click;
            // 
            // label_nama
            // 
            label_nama.AutoSize = true;
            label_nama.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_nama.Location = new Point(12, 9);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(65, 25);
            label_nama.TabIndex = 10;
            label_nama.Text = "label4";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Location = new Point(12, 34);
            label_username.Name = "label_username";
            label_username.Size = new Size(38, 15);
            label_username.TabIndex = 11;
            label_username.Text = "label4";
            // 
            // label_bio
            // 
            label_bio.AutoSize = true;
            label_bio.Location = new Point(12, 63);
            label_bio.Name = "label_bio";
            label_bio.Size = new Size(38, 15);
            label_bio.TabIndex = 12;
            label_bio.Text = "label4";
            // 
            // FormProfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(label_bio);
            Controls.Add(label_username);
            Controls.Add(label_nama);
            Controls.Add(button_simpan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input_bio);
            Controls.Add(input_nama);
            Name = "FormProfil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox input_nama;
        private RichTextBox input_bio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_simpan;
        private Label label_nama;
        private Label label_username;
        private Label label_bio;
    }
}