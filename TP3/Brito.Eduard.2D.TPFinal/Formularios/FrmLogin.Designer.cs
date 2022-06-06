namespace Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnLoguearEmpleado = new System.Windows.Forms.Button();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(341, 211);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PlaceholderText = "USUARIO";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 23);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(341, 262);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.PasswordChar = '*';
            this.TxtContrasenia.PlaceholderText = "CONTRASEÑA";
            this.TxtContrasenia.Size = new System.Drawing.Size(100, 23);
            this.TxtContrasenia.TabIndex = 1;
            this.TxtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasenia.UseWaitCursor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.Turquoise;
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAceptar.Location = new System.Drawing.Point(181, 300);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(110, 31);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(496, 300);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 31);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnLoguearEmpleado
            // 
            this.BtnLoguearEmpleado.BackColor = System.Drawing.Color.MediumPurple;
            this.BtnLoguearEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLoguearEmpleado.ForeColor = System.Drawing.Color.Black;
            this.BtnLoguearEmpleado.Location = new System.Drawing.Point(327, 339);
            this.BtnLoguearEmpleado.Name = "BtnLoguearEmpleado";
            this.BtnLoguearEmpleado.Size = new System.Drawing.Size(135, 31);
            this.BtnLoguearEmpleado.TabIndex = 4;
            this.BtnLoguearEmpleado.Text = "Loguear Empleado";
            this.BtnLoguearEmpleado.UseVisualStyleBackColor = false;
            this.BtnLoguearEmpleado.Click += new System.EventHandler(this.BtnLoguearEmpleado_Click_1);
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PictureBoxLogo.BackgroundImage = global::Formularios.Properties.Resources.Logo_Mundo_Play_Shop;
            this.PictureBoxLogo.Image = global::Formularios.Properties.Resources.Logo_PNG_2;
            this.PictureBoxLogo.InitialImage = global::Formularios.Properties.Resources.Logo_Mundo_Play_Shop;
            this.PictureBoxLogo.Location = new System.Drawing.Point(235, 12);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(305, 176);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 5;
            this.PictureBoxLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.BtnLoguearEmpleado);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo Play Shop > Login";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnLoguearEmpleado;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
    }
}