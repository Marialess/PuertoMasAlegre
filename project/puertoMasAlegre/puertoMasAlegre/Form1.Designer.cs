namespace puertoMasAlegre
{
    partial class index
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
            panel1 = new Panel();
            pic1 = new PictureBox();
            panel2 = new Panel();
            txtLogin = new TextBox();
            btnEntrar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(pic1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 708);
            panel1.TabIndex = 0;
            // 
            // pic1
            // 
            pic1.Image = Properties.Resources.Illustration;
            pic1.Location = new Point(605, 88);
            pic1.Name = "pic1";
            pic1.Size = new Size(444, 523);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.TabIndex = 1;
            pic1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtLogin);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(41, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 630);
            panel2.TabIndex = 0;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(255, 192, 255);
            txtLogin.Location = new Point(39, 374);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(344, 27);
            txtLogin.TabIndex = 8;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.Gold;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(171, 529);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(148, 45);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Sing in    -->";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(39, 441);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(39, 351);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 239);
            label2.Name = "label2";
            label2.Size = new Size(169, 60);
            label2.TabIndex = 2;
            label2.Text = "Sing in";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(38, 196);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 1;
            label1.Text = "Welcome back !!!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_removebg_preview_2;
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(255, 192, 255);
            txtPassword.Location = new Point(39, 464);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(344, 27);
            txtPassword.TabIndex = 9;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1106, 707);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "index";
            Text = "Index";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnEntrar;
        private Label label4;
        private Label label3;
        private TextBox txtLogin;
        private TextBox txtPassword;
    }
}
