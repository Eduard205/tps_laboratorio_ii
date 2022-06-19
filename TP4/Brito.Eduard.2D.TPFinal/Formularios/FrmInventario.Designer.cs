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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaJuegos)).BeginInit();
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
            this.DataGridListaJuegos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListaJuegos_CellContentClick);
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
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabInventario);
            this.Controls.Add(this.DataGridListaJuegos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo Play Shop > Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListaJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridListaJuegos;
        private System.Windows.Forms.Label LabInventario;
    }
}