namespace Estafeta.Formularios
{
    partial class Update_Logistica
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
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.DtpFechaA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxCostoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxDestinoA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxTipoA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(586, 384);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(169, 44);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DtpFechaA
            // 
            this.DtpFechaA.CustomFormat = "yyyy-mm-dd";
            this.DtpFechaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaA.Location = new System.Drawing.Point(194, 308);
            this.DtpFechaA.Name = "DtpFechaA";
            this.DtpFechaA.Size = new System.Drawing.Size(561, 44);
            this.DtpFechaA.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha:";
            // 
            // TxtBoxCostoA
            // 
            this.TxtBoxCostoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCostoA.Location = new System.Drawing.Point(194, 237);
            this.TxtBoxCostoA.Name = "TxtBoxCostoA";
            this.TxtBoxCostoA.Size = new System.Drawing.Size(180, 44);
            this.TxtBoxCostoA.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Costo:";
            // 
            // TxtBoxDestinoA
            // 
            this.TxtBoxDestinoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDestinoA.Location = new System.Drawing.Point(194, 155);
            this.TxtBoxDestinoA.Name = "TxtBoxDestinoA";
            this.TxtBoxDestinoA.Size = new System.Drawing.Size(541, 44);
            this.TxtBoxDestinoA.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Destino:";
            // 
            // CBoxTipoA
            // 
            this.CBoxTipoA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBoxTipoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTipoA.FormattingEnabled = true;
            this.CBoxTipoA.Items.AddRange(new object[] {
            "Paquete Aereo",
            "Paquete Terrestre",
            "Mensajeria"});
            this.CBoxTipoA.Location = new System.Drawing.Point(194, 78);
            this.CBoxTipoA.Name = "CBoxTipoA";
            this.CBoxTipoA.Size = new System.Drawing.Size(226, 45);
            this.CBoxTipoA.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo:";
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.Enabled = false;
            this.TxtBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxId.Location = new System.Drawing.Point(194, 12);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.Size = new System.Drawing.Size(127, 44);
            this.TxtBoxId.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID:";
            // 
            // Update_Logistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.DtpFechaA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxCostoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxDestinoA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxTipoA);
            this.Controls.Add(this.label1);
            this.Name = "Update_Logistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Update_Logistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker DtpFechaA;
        public System.Windows.Forms.TextBox TxtBoxCostoA;
        public System.Windows.Forms.TextBox TxtBoxDestinoA;
        public System.Windows.Forms.ComboBox CBoxTipoA;
        public System.Windows.Forms.TextBox TxtBoxId;
        private System.Windows.Forms.Label label5;
    }
}