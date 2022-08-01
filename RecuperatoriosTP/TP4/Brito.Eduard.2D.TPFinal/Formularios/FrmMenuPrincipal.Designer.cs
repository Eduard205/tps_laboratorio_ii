namespace Formularios
{
    partial class FrmMenuPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox2Logo = new System.Windows.Forms.PictureBox();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DataGridListaClientes = new System.Windows.Forms.DataGridView();
            this.BtnGuardarArchivoClientes = new System.Windows.Forms.Button();
            this.labFechaReloj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2Logo
            // 
            this.pictureBox2Logo.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2Logo.Image = global::Formularios.Properties.Resources.Logo_PNG_2;
            this.pictureBox2Logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2Logo.Name = "pictureBox2Logo";
            this.pictureBox2Logo.Size = new System.Drawing.Size(207, 97);
            this.pictureBox2Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Logo.TabIndex = 0;
            this.pictureBox2Logo.TabStop = false;
            // 
            // BtnVender
            // 
            this.BtnVender.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnVender.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVender.Location = new System.Drawing.Point(54, 143);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(116, 33);
            this.BtnVender.TabIndex = 1;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = false;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackColor = System.Drawing.Color.Gold;
            this.BtnInventario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInventario.Location = new System.Drawing.Point(54, 250);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(116, 33);
            this.BtnInventario.TabIndex = 2;
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.UseVisualStyleBackColor = false;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.Violet;
            this.BtnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClientes.Location = new System.Drawing.Point(54, 197);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(116, 33);
            this.BtnClientes.TabIndex = 3;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.Location = new System.Drawing.Point(54, 304);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(116, 33);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DataGridListaClientes
            // 
            this.DataGridListaClientes.AllowUserToAddRows = false;
            this.DataGridListaClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListaClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridListaClientes.EnableHeadersVisualStyles = false;
            this.DataGridListaClientes.Location = new System.Drawing.Point(277, 143);
            this.DataGridListaClientes.Name = "DataGridListaClientes";
            this.DataGridListaClientes.ReadOnly = true;
            this.DataGridListaClientes.RowHeadersVisible = false;
            this.DataGridListaClientes.RowTemplate.Height = 25;
            this.DataGridListaClientes.Size = new System.Drawing.Size(405, 225);
            this.DataGridListaClientes.TabIndex = 7;
            // 
            // BtnGuardarArchivoClientes
            // 
            this.BtnGuardarArchivoClientes.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnGuardarArchivoClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarArchivoClientes.Location = new System.Drawing.Point(277, 383);
            this.BtnGuardarArchivoClientes.Name = "BtnGuardarArchivoClientes";
            this.BtnGuardarArchivoClientes.Size = new System.Drawing.Size(186, 33);
            this.BtnGuardarArchivoClientes.TabIndex = 9;
            this.BtnGuardarArchivoClientes.Text = "Guardar Archivo de Clientes";
            this.BtnGuardarArchivoClientes.UseVisualStyleBackColor = false;
            this.BtnGuardarArchivoClientes.Click += new System.EventHandler(this.BtnGuardarArchivoClientes_Click);
            // 
            // labFechaReloj
            // 
            this.labFechaReloj.AutoSize = true;
            this.labFechaReloj.BackColor = System.Drawing.Color.Yellow;
            this.labFechaReloj.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labFechaReloj.Location = new System.Drawing.Point(617, 12);
            this.labFechaReloj.Name = "labFechaReloj";
            this.labFechaReloj.Size = new System.Drawing.Size(105, 20);
            this.labFechaReloj.TabIndex = 10;
            this.labFechaReloj.Text = "labFechaReloj";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labFechaReloj);
            this.Controls.Add(this.BtnGuardarArchivoClientes);
            this.Controls.Add(this.DataGridListaClientes);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.pictureBox2Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo Play Shop > Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2Logo;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DataGridListaClientes;
        private System.Windows.Forms.Button BtnGuardarArchivoClientes;
        private System.Windows.Forms.Label labFechaReloj;
    }
}
