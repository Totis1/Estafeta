namespace Estafeta.Formularios
{
    partial class Update_Almacen
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
            this.DtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.DtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxDimensiones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxTipoPaquete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DtpFechaEntrada
            // 
            this.DtpFechaEntrada.CustomFormat = "yyyy-mm-dd";
            this.DtpFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEntrada.Location = new System.Drawing.Point(407, 246);
            this.DtpFechaEntrada.Name = "DtpFechaEntrada";
            this.DtpFechaEntrada.Size = new System.Drawing.Size(226, 44);
            this.DtpFechaEntrada.TabIndex = 27;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.Location = new System.Drawing.Point(462, 390);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(171, 44);
            this.BtnInsertar.TabIndex = 26;
            this.BtnInsertar.Text = "Actualizar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // DtpFechaSalida
            // 
            this.DtpFechaSalida.CustomFormat = "yyyy-mm-dd";
            this.DtpFechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaSalida.Location = new System.Drawing.Point(407, 317);
            this.DtpFechaSalida.Name = "DtpFechaSalida";
            this.DtpFechaSalida.Size = new System.Drawing.Size(226, 44);
            this.DtpFechaSalida.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha de Salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de Entrada:";
            // 
            // TxtBoxDimensiones
            // 
            this.TxtBoxDimensiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDimensiones.Location = new System.Drawing.Point(231, 167);
            this.TxtBoxDimensiones.Name = "TxtBoxDimensiones";
            this.TxtBoxDimensiones.Size = new System.Drawing.Size(402, 44);
            this.TxtBoxDimensiones.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dimensiones:";
            // 
            // CBoxTipoPaquete
            // 
            this.CBoxTipoPaquete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBoxTipoPaquete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTipoPaquete.FormattingEnabled = true;
            this.CBoxTipoPaquete.Items.AddRange(new object[] {
            "Paquete Aereo",
            "Paquete Terrestre",
            "Mensajeria"});
            this.CBoxTipoPaquete.Location = new System.Drawing.Point(278, 91);
            this.CBoxTipoPaquete.Name = "CBoxTipoPaquete";
            this.CBoxTipoPaquete.Size = new System.Drawing.Size(355, 45);
            this.CBoxTipoPaquete.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo de paquete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 37);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID del Paquete:";
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.Enabled = false;
            this.TxtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxID.Location = new System.Drawing.Point(256, 13);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(377, 44);
            this.TxtBoxID.TabIndex = 29;
            // 
            // Update_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.TxtBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtpFechaEntrada);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.DtpFechaSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxDimensiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxTipoPaquete);
            this.Controls.Add(this.label1);
            this.Name = "Update_Almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Almacen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DateTimePicker DtpFechaEntrada;
        public System.Windows.Forms.DateTimePicker DtpFechaSalida;
        public System.Windows.Forms.TextBox TxtBoxDimensiones;
        public System.Windows.Forms.ComboBox CBoxTipoPaquete;
        public System.Windows.Forms.TextBox TxtBoxID;
    }
}