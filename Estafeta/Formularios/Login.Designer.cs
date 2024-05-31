namespace Estafeta.Formularios
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxUsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxPass = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(647, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo del Usuario: ";
            // 
            // TxtBoxUsu
            // 
            this.TxtBoxUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxUsu.Location = new System.Drawing.Point(641, 325);
            this.TxtBoxUsu.Name = "TxtBoxUsu";
            this.TxtBoxUsu.Size = new System.Drawing.Size(428, 44);
            this.TxtBoxUsu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(647, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña: ";
            // 
            // TxtBoxPass
            // 
            this.TxtBoxPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPass.Location = new System.Drawing.Point(641, 426);
            this.TxtBoxPass.Name = "TxtBoxPass";
            this.TxtBoxPass.PasswordChar = '*';
            this.TxtBoxPass.Size = new System.Drawing.Size(428, 44);
            this.TxtBoxPass.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnLogin.FlatAppearance.BorderSize = 8;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLogin.Location = new System.Drawing.Point(920, 496);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLogin.Size = new System.Drawing.Size(149, 37);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Iniciar sesíon ";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estafeta.Properties.Resources.Estafeta_img;
            this.pictureBox1.Location = new System.Drawing.Point(-33, -248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1201, 863);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 591);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxUsu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxUsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxPass;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}