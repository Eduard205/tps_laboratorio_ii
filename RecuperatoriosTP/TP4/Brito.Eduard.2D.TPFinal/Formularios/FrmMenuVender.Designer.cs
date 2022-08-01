namespace Formularios
{
    partial class FrmMenuVender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuVender));
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labCliente = new System.Windows.Forms.Label();
            this.labVideoJuego = new System.Windows.Forms.Label();
            this.comboBoxVideoJuego = new System.Windows.Forms.ComboBox();
            this.labCantidad = new System.Windows.Forms.Label();
            this.comboBoxCantidad = new System.Windows.Forms.ComboBox();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.btnFacturarVenta = new System.Windows.Forms.Button();
            this.BtnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCargarVenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIDEOJUEGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTotalAFacturar = new System.Windows.Forms.Label();
            this.txtTotalAFacturar = new System.Windows.Forms.TextBox();
            this.pictureBox2Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCargarVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(120, 70);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(154, 23);
            this.comboBoxCliente.TabIndex = 0;
            // 
            // labCliente
            // 
            this.labCliente.AutoSize = true;
            this.labCliente.BackColor = System.Drawing.Color.Salmon;
            this.labCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCliente.Location = new System.Drawing.Point(12, 73);
            this.labCliente.Name = "labCliente";
            this.labCliente.Size = new System.Drawing.Size(68, 20);
            this.labCliente.TabIndex = 1;
            this.labCliente.Text = "CLIENTE";
            // 
            // labVideoJuego
            // 
            this.labVideoJuego.AutoSize = true;
            this.labVideoJuego.BackColor = System.Drawing.Color.Salmon;
            this.labVideoJuego.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labVideoJuego.Location = new System.Drawing.Point(12, 109);
            this.labVideoJuego.Name = "labVideoJuego";
            this.labVideoJuego.Size = new System.Drawing.Size(102, 20);
            this.labVideoJuego.TabIndex = 2;
            this.labVideoJuego.Text = "VIDEOJUEGO";
            // 
            // comboBoxVideoJuego
            // 
            this.comboBoxVideoJuego.FormattingEnabled = true;
            this.comboBoxVideoJuego.Location = new System.Drawing.Point(120, 106);
            this.comboBoxVideoJuego.Name = "comboBoxVideoJuego";
            this.comboBoxVideoJuego.Size = new System.Drawing.Size(154, 23);
            this.comboBoxVideoJuego.TabIndex = 3;
            // 
            // labCantidad
            // 
            this.labCantidad.AutoSize = true;
            this.labCantidad.BackColor = System.Drawing.Color.Salmon;
            this.labCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labCantidad.Location = new System.Drawing.Point(12, 145);
            this.labCantidad.Name = "labCantidad";
            this.labCantidad.Size = new System.Drawing.Size(88, 20);
            this.labCantidad.TabIndex = 4;
            this.labCantidad.Text = "CANTIDAD";
            // 
            // comboBoxCantidad
            // 
            this.comboBoxCantidad.FormattingEnabled = true;
            this.comboBoxCantidad.Location = new System.Drawing.Point(120, 142);
            this.comboBoxCantidad.Name = "comboBoxCantidad";
            this.comboBoxCantidad.Size = new System.Drawing.Size(154, 23);
            this.comboBoxCantidad.TabIndex = 5;
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.BackColor = System.Drawing.Color.Yellow;
            this.btnCargarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargarVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCargarVenta.Location = new System.Drawing.Point(12, 238);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(151, 27);
            this.btnCargarVenta.TabIndex = 6;
            this.btnCargarVenta.Text = "CARGAR VENTA";
            this.btnCargarVenta.UseVisualStyleBackColor = false;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // btnFacturarVenta
            // 
            this.btnFacturarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFacturarVenta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFacturarVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFacturarVenta.Location = new System.Drawing.Point(12, 304);
            this.btnFacturarVenta.Name = "btnFacturarVenta";
            this.btnFacturarVenta.Size = new System.Drawing.Size(151, 27);
            this.btnFacturarVenta.TabIndex = 7;
            this.btnFacturarVenta.Text = "FACTURAR VENTA";
            this.btnFacturarVenta.UseVisualStyleBackColor = false;
            this.btnFacturarVenta.Click += new System.EventHandler(this.btnFacturarVenta_Click_1);
            // 
            // BtnVolverMenuPrincipal
            // 
            this.BtnVolverMenuPrincipal.BackColor = System.Drawing.Color.Tomato;
            this.BtnVolverMenuPrincipal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVolverMenuPrincipal.Location = new System.Drawing.Point(642, 12);
            this.BtnVolverMenuPrincipal.Name = "BtnVolverMenuPrincipal";
            this.BtnVolverMenuPrincipal.Size = new System.Drawing.Size(146, 29);
            this.BtnVolverMenuPrincipal.TabIndex = 12;
            this.BtnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            this.BtnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            this.BtnVolverMenuPrincipal.Click += new System.EventHandler(this.BtnVolverMenuPrincipal_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(12, 271);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(151, 27);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "NOMBRE DEL CLIENTE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "VIDEOJUEGO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // DataGridCargarVenta
            // 
            this.DataGridCargarVenta.AllowUserToAddRows = false;
            this.DataGridCargarVenta.AllowUserToDeleteRows = false;
            this.DataGridCargarVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridCargarVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridCargarVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCargarVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCargarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCargarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridCargarVenta.EnableHeadersVisualStyles = false;
            this.DataGridCargarVenta.Location = new System.Drawing.Point(319, 70);
            this.DataGridCargarVenta.Name = "DataGridCargarVenta";
            this.DataGridCargarVenta.ReadOnly = true;
            this.DataGridCargarVenta.RowHeadersVisible = false;
            this.DataGridCargarVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DataGridCargarVenta.RowTemplate.Height = 25;
            this.DataGridCargarVenta.Size = new System.Drawing.Size(427, 186);
            this.DataGridCargarVenta.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CLIENTE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "VIDEOJUEGO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 102;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "CANTIDAD";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "PRECIO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "TOTAL A COBRAR";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Width = 75;
            // 
            // VIDEOJUEGO
            // 
            this.VIDEOJUEGO.HeaderText = "VIDEOJUEGO";
            this.VIDEOJUEGO.Name = "VIDEOJUEGO";
            // 
            // labTotalAFacturar
            // 
            this.labTotalAFacturar.AutoSize = true;
            this.labTotalAFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labTotalAFacturar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTotalAFacturar.Location = new System.Drawing.Point(387, 270);
            this.labTotalAFacturar.Name = "labTotalAFacturar";
            this.labTotalAFacturar.Size = new System.Drawing.Size(151, 20);
            this.labTotalAFacturar.TabIndex = 19;
            this.labTotalAFacturar.Text = "TOTAL A FACTURAR";
            this.labTotalAFacturar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalAFacturar
            // 
            this.txtTotalAFacturar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalAFacturar.Location = new System.Drawing.Point(544, 267);
            this.txtTotalAFacturar.Name = "txtTotalAFacturar";
            this.txtTotalAFacturar.Size = new System.Drawing.Size(131, 25);
            this.txtTotalAFacturar.TabIndex = 20;
            // 
            // pictureBox2Logo
            // 
            this.pictureBox2Logo.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2Logo.Image = global::Formularios.Properties.Resources.Logo_PNG_2;
            this.pictureBox2Logo.Location = new System.Drawing.Point(12, 364);
            this.pictureBox2Logo.Name = "pictureBox2Logo";
            this.pictureBox2Logo.Size = new System.Drawing.Size(151, 74);
            this.pictureBox2Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Logo.TabIndex = 21;
            this.pictureBox2Logo.TabStop = false;
            // 
            // FrmMenuVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.pictureBox2Logo);
            this.Controls.Add(this.txtTotalAFacturar);
            this.Controls.Add(this.labTotalAFacturar);
            this.Controls.Add(this.DataGridCargarVenta);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.BtnVolverMenuPrincipal);
            this.Controls.Add(this.btnFacturarVenta);
            this.Controls.Add(this.btnCargarVenta);
            this.Controls.Add(this.comboBoxCantidad);
            this.Controls.Add(this.labCantidad);
            this.Controls.Add(this.comboBoxVideoJuego);
            this.Controls.Add(this.labVideoJuego);
            this.Controls.Add(this.labCliente);
            this.Controls.Add(this.comboBoxCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo Play Shop > Menu Vender";
            this.Load += new System.EventHandler(this.FrmMenuVender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCargarVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labCliente;
        private System.Windows.Forms.Label labVideoJuego;
        private System.Windows.Forms.ComboBox comboBoxVideoJuego;
        private System.Windows.Forms.Label labCantidad;
        private System.Windows.Forms.ComboBox comboBoxCantidad;
        private System.Windows.Forms.Button btnCargarVenta;
        private System.Windows.Forms.Button btnFacturarVenta;
        private System.Windows.Forms.Button BtnVolverMenuPrincipal;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridView DataGridCargarVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIDEOJUEGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label labTotalAFacturar;
        private System.Windows.Forms.TextBox txtTotalAFacturar;
        private System.Windows.Forms.PictureBox pictureBox2Logo;
    }
}