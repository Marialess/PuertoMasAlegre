namespace puertoMasAlegre
{
    partial class reportes
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnVentDiaria = new Button();
            btnVentSemanal = new Button();
            btnVentMensual = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnVentMensual);
            panel1.Controls.Add(btnVentSemanal);
            panel1.Controls.Add(btnVentDiaria);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 721);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1131, 125);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 32);
            label1.Name = "label1";
            label1.Size = new Size(224, 62);
            label1.TabIndex = 0;
            label1.Text = "Reportes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.metodo_de_pago_1;
            pictureBox1.Location = new Point(121, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.metodo_de_pago_1;
            pictureBox2.Location = new Point(468, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 224);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.metodo_de_pago_1;
            pictureBox3.Location = new Point(821, 231);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(170, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnVentDiaria
            // 
            btnVentDiaria.BackColor = Color.ForestGreen;
            btnVentDiaria.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentDiaria.ForeColor = SystemColors.ButtonHighlight;
            btnVentDiaria.Location = new Point(121, 499);
            btnVentDiaria.Name = "btnVentDiaria";
            btnVentDiaria.Size = new Size(170, 52);
            btnVentDiaria.TabIndex = 4;
            btnVentDiaria.Text = "Venta diaria";
            btnVentDiaria.UseVisualStyleBackColor = false;
            // 
            // btnVentSemanal
            // 
            btnVentSemanal.BackColor = Color.ForestGreen;
            btnVentSemanal.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentSemanal.ForeColor = SystemColors.ButtonHighlight;
            btnVentSemanal.Location = new Point(468, 499);
            btnVentSemanal.Name = "btnVentSemanal";
            btnVentSemanal.Size = new Size(170, 52);
            btnVentSemanal.TabIndex = 5;
            btnVentSemanal.Text = "Venta semanal";
            btnVentSemanal.UseVisualStyleBackColor = false;
            // 
            // btnVentMensual
            // 
            btnVentMensual.BackColor = Color.ForestGreen;
            btnVentMensual.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentMensual.ForeColor = SystemColors.ButtonHighlight;
            btnVentMensual.Location = new Point(821, 499);
            btnVentMensual.Name = "btnVentMensual";
            btnVentMensual.Size = new Size(170, 52);
            btnVentMensual.TabIndex = 6;
            btnVentMensual.Text = "Venta mensual";
            btnVentMensual.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.ForestGreen;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(468, 636);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 52);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 711);
            Controls.Add(panel1);
            Name = "reportes";
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnVentMensual;
        private Button btnVentSemanal;
        private Button btnVentDiaria;
        private Button btnCancelar;
    }
}