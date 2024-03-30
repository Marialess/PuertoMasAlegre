namespace puertoMasAlegre
{
    partial class paginaPrincipas
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnPromocion = new Button();
            btnSalidas = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            btnRegistro = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 718);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_removebg_preview_2;
            pictureBox1.Location = new Point(545, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(btnPromocion);
            panel2.Controls.Add(btnSalidas);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnReportes);
            panel2.Controls.Add(btnRegistro);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 718);
            panel2.TabIndex = 0;
            // 
            // btnPromocion
            // 
            btnPromocion.Cursor = Cursors.Hand;
            btnPromocion.FlatStyle = FlatStyle.Flat;
            btnPromocion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPromocion.ForeColor = SystemColors.ButtonHighlight;
            btnPromocion.Image = Properties.Resources.sale_2_1;
            btnPromocion.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromocion.Location = new Point(2, 379);
            btnPromocion.Name = "btnPromocion";
            btnPromocion.Size = new Size(306, 79);
            btnPromocion.TabIndex = 6;
            btnPromocion.Text = "Promociones";
            btnPromocion.UseVisualStyleBackColor = true;
            btnPromocion.Click += btnPromocion_Click;
            // 
            // btnSalidas
            // 
            btnSalidas.Cursor = Cursors.Hand;
            btnSalidas.FlatStyle = FlatStyle.Flat;
            btnSalidas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalidas.ForeColor = SystemColors.ButtonHighlight;
            btnSalidas.Image = Properties.Resources.product_management_1;
            btnSalidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalidas.Location = new Point(2, 304);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(306, 79);
            btnSalidas.TabIndex = 5;
            btnSalidas.Text = "Movimiento de productos";
            btnSalidas.UseVisualStyleBackColor = true;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // btnInventario
            // 
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = SystemColors.ButtonHighlight;
            btnInventario.Image = Properties.Resources.customer_loyalty_1;
            btnInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventario.Location = new Point(2, 230);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(306, 79);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = SystemColors.ButtonHighlight;
            btnReportes.Image = Properties.Resources.promotion_1;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(2, 155);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(306, 79);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = SystemColors.ButtonHighlight;
            btnRegistro.Image = Properties.Resources.administration_1;
            btnRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistro.Location = new Point(2, 81);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(306, 79);
            btnRegistro.TabIndex = 2;
            btnRegistro.Text = "Registro de producto";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(69, 24);
            label1.Name = "label1";
            label1.Size = new Size(215, 38);
            label1.TabIndex = 1;
            label1.Text = "Menú Principal";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Vector;
            pictureBox2.Location = new Point(25, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // paginaPrincipas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(1110, 711);
            Controls.Add(panel1);
            Name = "paginaPrincipas";
            Text = "Menu Principal";
            Load += paginaPrincipas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnInventario;
        private Button btnReportes;
        private Button btnRegistro;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnPromocion;
        private Button btnSalidas;
    }
}