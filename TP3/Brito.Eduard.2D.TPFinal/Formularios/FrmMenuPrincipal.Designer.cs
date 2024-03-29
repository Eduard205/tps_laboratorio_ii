﻿namespace Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox2Logo = new System.Windows.Forms.PictureBox();
            this.BtnVender = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DataGridListaClientes = new System.Windows.Forms.DataGridView();
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
            this.pictureBox2Logo.Size = new System.Drawing.Size(142, 63);
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
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.DarkGray;
            this.BtnReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReportes.Location = new System.Drawing.Point(54, 308);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(116, 33);
            this.BtnReportes.TabIndex = 4;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.Location = new System.Drawing.Point(54, 362);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(116, 33);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(560, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // DataGridListaClientes
            // 
            this.DataGridListaClientes.AllowUserToAddRows = false;
            this.DataGridListaClientes.AllowUserToDeleteRows = false;
            this.DataGridListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridListaClientes.Location = new System.Drawing.Point(277, 143);
            this.DataGridListaClientes.Name = "DataGridListaClientes";
            this.DataGridListaClientes.ReadOnly = true;
            this.DataGridListaClientes.RowHeadersVisible = false;
            this.DataGridListaClientes.RowTemplate.Height = 25;
            this.DataGridListaClientes.Size = new System.Drawing.Size(405, 225);
            this.DataGridListaClientes.TabIndex = 7;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridListaClientes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnReportes);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2Logo;
        private System.Windows.Forms.Button BtnVender;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DataGridListaClientes;
    }
}
