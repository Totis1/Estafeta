namespace Estafeta.Formularios
{
    partial class Update_Carga_Aerea
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
            this.TxtBoxOrigen = new System.Windows.Forms.TextBox();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxVolumen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(506, 462);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(175, 44);
            this.BtnActualizar.TabIndex = 41;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtBoxOrigen
            // 
            this.TxtBoxOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxOrigen.Location = new System.Drawing.Point(279, 61);
            this.TxtBoxOrigen.Name = "TxtBoxOrigen";
            this.TxtBoxOrigen.Size = new System.Drawing.Size(402, 44);
            this.TxtBoxOrigen.TabIndex = 40;
            // 
            // CboxEstado
            // 
            this.CboxEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxEstado.FormattingEnabled = true;
            this.CboxEstado.Items.AddRange(new object[] {
            "En_transito",
            "Entregado",
            "Retrasado"});
            this.CboxEstado.Location = new System.Drawing.Point(326, 387);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(355, 45);
            this.CboxEstado.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 37);
            this.label6.TabIndex = 38;
            this.label6.Text = "Estado de Entrega:";
            // 
            // TxtBoxVolumen
            // 
            this.TxtBoxVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxVolumen.Location = new System.Drawing.Point(279, 323);
            this.TxtBoxVolumen.Name = "TxtBoxVolumen";
            this.TxtBoxVolumen.Size = new System.Drawing.Size(402, 44);
            this.TxtBoxVolumen.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 37);
            this.label5.TabIndex = 36;
            this.label5.Text = "Volumen(cm^3):";
            // 
            // TxtBoxPeso
            // 
            this.TxtBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPeso.Location = new System.Drawing.Point(279, 255);
            this.TxtBoxPeso.Name = "TxtBoxPeso";
            this.TxtBoxPeso.Size = new System.Drawing.Size(402, 44);
            this.TxtBoxPeso.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "Peso(kg):";
            // 
            // DtpFechaEnvio
            // 
            this.DtpFechaEnvio.CustomFormat = "yyyy-mm-dd";
            this.DtpFechaEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEnvio.Location = new System.Drawing.Point(455, 187);
            this.DtpFechaEnvio.Name = "DtpFechaEnvio";
            this.DtpFechaEnvio.Size = new System.Drawing.Size(226, 44);
            this.DtpFechaEnvio.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fecha de Envio:";
            // 
            // TxtBoxDestino
            // 
            this.TxtBoxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDestino.Location = new System.Drawing.Point(279, 122);
            this.TxtBoxDestino.Name = "TxtBoxDestino";
            this.TxtBoxDestino.Size = new System.Drawing.Size(402, 44);
            this.TxtBoxDestino.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 37);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID:";
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.Enabled = false;
            this.TxtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxID.Location = new System.Drawing.Point(279, 6);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(402, 44);
            this.TxtBoxID.TabIndex = 43;
            // 
            // Update_Carga_Aerea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 522);
            this.Controls.Add(this.TxtBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtBoxOrigen);
            this.Controls.Add(this.CboxEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBoxVolumen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBoxPeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpFechaEnvio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update_Carga_Aerea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Carga_Aerea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtBoxOrigen;
        public System.Windows.Forms.ComboBox CboxEstado;
        public System.Windows.Forms.TextBox TxtBoxVolumen;
        public System.Windows.Forms.TextBox TxtBoxPeso;
        public System.Windows.Forms.DateTimePicker DtpFechaEnvio;
        public System.Windows.Forms.TextBox TxtBoxDestino;
        public System.Windows.Forms.TextBox TxtBoxID;
    }
}