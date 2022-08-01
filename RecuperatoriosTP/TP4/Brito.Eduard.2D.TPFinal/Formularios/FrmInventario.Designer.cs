namespace Formularios
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.DataGridListaJuegos = new System.Windows.Forms.DataGridView();
            this.LabInventario = new System.Windows.Forms.Label();
            this.BtnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.BtnImportarBdVideoJuegos = new System.Windows.Forms.Button();
            this.pictureBox2Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridListaJuegos
            // 
            this.DataGridListaJuegos.AllowUserToAddRows = false;
            this.DataGridListaJuegos.AllowUserToDeleteRows = false;
            this.DataGridListaJuegos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridListaJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridListaJuegos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridListaJuegos.BackgroundColor = System.Drawing.Color.White;
            this.DataGridListaJuegos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListaJuegos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridListaJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridListaJuegos.EnableHeadersVisualStyles = false;
            this.DataGridListaJuegos.Location = new System.Drawing.Point(94, 86);
            this.DataGridListaJuegos.Name = "DataGridListaJuegos";
            this.DataGridListaJuegos.ReadOnly = true;
            this.DataGridListaJuegos.RowHeadersVisible = false;
            this.DataGridListaJuegos.RowTemplate.Height = 25;
            this.DataGridListaJuegos.Size = new System.Drawing.Size(610, 219);
            this.DataGridListaJuegos.TabIndex = 8;
            // 
            // LabInventario
            // 
            this.LabInventario.AutoSize = true;
            this.LabInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LabInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabInventario.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabInventario.Location = new System.Drawing.Point(308, 24);
            this.LabInventario.Name = "LabInventario";
            this.LabInventario.Size = new System.Drawing.Size(144, 29);
            this.LabInventario.TabIndex = 9;
            this.LabInventario.Text = "INVENTARIO";
            // 
            // BtnVolverMenuPrincipal
            // 
            this.BtnVolverMenuPrincipal.BackColor = System.Drawing.Color.Tomato;
            this.BtnVolverMenuPrincipal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnVolverMenuPrincipal.Location = new System.Drawing.Point(632, 24);
            this.BtnVolverMenuPrincipal.Name = "BtnVolverMenuPrincipal";
            this.BtnVolverMenuPrincipal.Size = new System.Drawing.Size(146, 29);
            this.BtnVolverMenuPrincipal.TabIndex = 12;
            this.BtnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            this.BtnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            this.BtnVolverMenuPrincipal.Click += new System.EventHandler(this.BtnVolverMenuPrincipal_Click);
            // 
            // BtnImportarBdVideoJuegos
            // 
            this.BtnImportarBdVideoJuegos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnImportarBdVideoJuegos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnImportarBdVideoJuegos.Location = new System.Drawing.Point(94, 331);
            this.BtnImportarBdVideoJuegos.Name = "BtnImportarBdVideoJuegos";
            this.BtnImportarBdVideoJuegos.Size = new System.Drawing.Size(236, 33);
            this.BtnImportarBdVideoJuegos.TabIndex = 13;
            this.BtnImportarBdVideoJuegos.Text = "Importar Inventario de VideoJuegos";
            this.BtnImportarBdVideoJuegos.UseVisualStyleBackColor = false;
            this.BtnImportarBdVideoJuegos.Click += new System.EventHandler(this.BtnImportarBdVideoJuegos_Click);
            // 
            // pictureBox2Logo
            // 
            this.pictureBox2Logo.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2Logo.Image = global::Formularios.Properties.Resources.Logo_PNG_2;
            this.pictureBox2Logo.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2Logo.Name = "pictureBox2Logo";
            this.pictureBox2Logo.Size = new System.Drawing.Size(151, 74);
            this.pictureBox2Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Logo.TabIndex = 22;
            this.pictureBox2Logo.TabStop = false;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2Logo);
            this.Controls.Add(this.BtnImportarBdVideoJuegos);
            this.Controls.Add(this.BtnVolverMenuPrincipal);
            this.Controls.Add(this.LabInventario);
            this.Controls.Add(this.DataGridListaJuegos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo Play Shop > Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaJuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridListaJuegos;
        private System.Windows.Forms.Label LabInventario;
        private System.Windows.Forms.Button BtnVolverMenuPrincipal;
        private System.Windows.Forms.Button BtnImportarBdVideoJuegos;
        private System.Windows.Forms.PictureBox pictureBox2Logo;
    }
}