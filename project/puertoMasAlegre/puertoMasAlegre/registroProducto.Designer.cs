namespace puertoMasAlegre
{
    partial class registroProducto
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNombre = new TextBox();
            txtDesc = new TextBox();
            txtModelo = new TextBox();
            txtNumSerie = new TextBox();
            txtPrecio = new TextBox();
            txtCant = new TextBox();
            dtEntrada = new DateTimePicker();
            btnIngresar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(dtEntrada);
            panel1.Controls.Add(txtCant);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(txtNumSerie);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(txtDesc);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1119, 721);
            panel1.TabIndex = 0;
            panel1.Paint += this.panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.ForestGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 92);
            panel2.TabIndex = 0;
            panel2.Paint += this.panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(464, 60);
            label1.TabIndex = 0;
            label1.Text = "Registro de producto";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(33, 112);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 1;
            label2.Text = "Ingresar un producto";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 173);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 236);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 295);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 354);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 5;
            label6.Text = "Número de serie";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 412);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 6;
            label7.Text = "Categoría";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 531);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 7;
            label8.Text = "Cantidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 473);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 8;
            label9.Text = "Precio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 587);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 9;
            label10.Text = "Fecha de entrada";
            label10.Click += label10_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ScrollBar;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(353, 173);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(490, 27);
            txtNombre.TabIndex = 10;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = SystemColors.ScrollBar;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Location = new Point(353, 229);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(490, 27);
            txtDesc.TabIndex = 11;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = SystemColors.ScrollBar;
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Location = new Point(353, 288);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(490, 27);
            txtModelo.TabIndex = 12;
            // 
            // txtNumSerie
            // 
            txtNumSerie.BackColor = SystemColors.ScrollBar;
            txtNumSerie.BorderStyle = BorderStyle.FixedSingle;
            txtNumSerie.Location = new Point(353, 347);
            txtNumSerie.Name = "txtNumSerie";
            txtNumSerie.Size = new Size(490, 27);
            txtNumSerie.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ScrollBar;
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(353, 466);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(138, 27);
            txtPrecio.TabIndex = 14;
            // 
            // txtCant
            // 
            txtCant.BackColor = SystemColors.ScrollBar;
            txtCant.BorderStyle = BorderStyle.FixedSingle;
            txtCant.Location = new Point(353, 524);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(138, 27);
            txtCant.TabIndex = 15;
            // 
            // dtEntrada
            // 
            dtEntrada.CalendarMonthBackground = SystemColors.ScrollBar;
            dtEntrada.CalendarTitleBackColor = SystemColors.ScrollBar;
            dtEntrada.Location = new Point(354, 583);
            dtEntrada.Name = "dtEntrada";
            dtEntrada.Size = new Size(283, 27);
            dtEntrada.TabIndex = 16;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.ForestGreen;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(113, 649);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(163, 48);
            btnIngresar.TabIndex = 17;
            btnIngresar.Text = "Ingresar Producto";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.ForestGreen;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(838, 649);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 48);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // registroProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 711);
            Controls.Add(panel1);
            Name = "registroProducto";
            Text = "Registro de producto";
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtNombre;
        private DateTimePicker dtEntrada;
        private TextBox txtCant;
        private TextBox txtPrecio;
        private TextBox txtNumSerie;
        private TextBox txtModelo;
        private TextBox txtDesc;
        private Button btnCancelar;
        private Button btnIngresar;
    }
}