namespace puertoMasAlegre
{
    partial class movimientoProducto
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtProducto = new TextBox();
            txtDesc = new TextBox();
            txtCant = new TextBox();
            txtDest = new TextBox();
            dtSalida = new DateTimePicker();
            btnSalida = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnSalida);
            panel1.Controls.Add(dtSalida);
            panel1.Controls.Add(txtDest);
            panel1.Controls.Add(txtCant);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-7, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1121, 719);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1118, 106);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(455, 62);
            label1.TabIndex = 0;
            label1.Text = "Salida del producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 179);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 282);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 378);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 476);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 4;
            label5.Text = "Destino";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 580);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 5;
            label6.Text = "Fecha de salida";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = SystemColors.ScrollBar;
            txtProducto.BorderStyle = BorderStyle.FixedSingle;
            txtProducto.Location = new Point(335, 180);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(472, 27);
            txtProducto.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = SystemColors.ScrollBar;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Location = new Point(335, 280);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(472, 27);
            txtDesc.TabIndex = 7;
            // 
            // txtCant
            // 
            txtCant.BackColor = SystemColors.ScrollBar;
            txtCant.BorderStyle = BorderStyle.FixedSingle;
            txtCant.Location = new Point(335, 376);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(190, 27);
            txtCant.TabIndex = 8;
            // 
            // txtDest
            // 
            txtDest.BackColor = SystemColors.ScrollBar;
            txtDest.BorderStyle = BorderStyle.FixedSingle;
            txtDest.Location = new Point(335, 474);
            txtDest.Name = "txtDest";
            txtDest.Size = new Size(472, 27);
            txtDest.TabIndex = 9;
            // 
            // dtSalida
            // 
            dtSalida.Location = new Point(335, 578);
            dtSalida.Name = "dtSalida";
            dtSalida.Size = new Size(301, 27);
            dtSalida.TabIndex = 10;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = Color.ForestGreen;
            btnSalida.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalida.ForeColor = SystemColors.ButtonHighlight;
            btnSalida.Location = new Point(209, 642);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(168, 61);
            btnSalida.TabIndex = 11;
            btnSalida.Text = "Registrar salida";
            btnSalida.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.ForestGreen;
            btnCancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(718, 642);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 61);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // movimientoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 711);
            Controls.Add(panel1);
            Name = "movimientoProducto";
            Text = "movimientoProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnSalida;
        private DateTimePicker dtSalida;
        private TextBox txtDest;
        private TextBox txtCant;
        private TextBox txtDesc;
        private TextBox txtProducto;
        private Label label6;
        private Button btnCancelar;
    }
}