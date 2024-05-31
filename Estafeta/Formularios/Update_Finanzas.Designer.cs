namespace Estafeta.Formularios
{
    partial class Update_Finanzas
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
            this.CboxCadT = new System.Windows.Forms.ComboBox();
            this.CboxTdT = new System.Windows.Forms.ComboBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CboxEdT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CboxMdP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CboxCdC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxCudT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxMdT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxDdT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaTransaccion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtBoxIDTransaccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CboxCadT
            // 
            this.CboxCadT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxCadT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxCadT.FormattingEnabled = true;
            this.CboxCadT.Items.AddRange(new object[] {
            "Ingresos",
            "Gastos",
            "Activos",
            "Pasivos"});
            this.CboxCadT.Location = new System.Drawing.Point(454, 479);
            this.CboxCadT.Name = "CboxCadT";
            this.CboxCadT.Size = new System.Drawing.Size(430, 45);
            this.CboxCadT.TabIndex = 61;
            // 
            // CboxTdT
            // 
            this.CboxTdT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxTdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxTdT.FormattingEnabled = true;
            this.CboxTdT.Items.AddRange(new object[] {
            "Venta",
            "Compra",
            "Inversión",
            "Pago de deuda"});
            this.CboxTdT.Location = new System.Drawing.Point(454, 121);
            this.CboxTdT.Name = "CboxTdT";
            this.CboxTdT.Size = new System.Drawing.Size(430, 45);
            this.CboxTdT.TabIndex = 60;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(886, 831);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(176, 48);
            this.BtnActualizar.TabIndex = 59;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxID.Location = new System.Drawing.Point(454, 765);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(430, 44);
            this.TxtBoxID.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 772);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 37);
            this.label10.TabIndex = 57;
            this.label10.Text = "ID de Empleado:";
            // 
            // CboxEdT
            // 
            this.CboxEdT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxEdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxEdT.FormattingEnabled = true;
            this.CboxEdT.Items.AddRange(new object[] {
            "Completada",
            "Pendiente",
            "Cancelada"});
            this.CboxEdT.Location = new System.Drawing.Point(454, 698);
            this.CboxEdT.Name = "CboxEdT";
            this.CboxEdT.Size = new System.Drawing.Size(430, 45);
            this.CboxEdT.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 701);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 37);
            this.label9.TabIndex = 55;
            this.label9.Text = "Estado de Transaccion:";
            // 
            // CboxMdP
            // 
            this.CboxMdP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxMdP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxMdP.FormattingEnabled = true;
            this.CboxMdP.Items.AddRange(new object[] {
            "Transferencia Bancaria",
            "Tarjeta de Crédito",
            "Efectivo"});
            this.CboxMdP.Location = new System.Drawing.Point(454, 622);
            this.CboxMdP.Name = "CboxMdP";
            this.CboxMdP.Size = new System.Drawing.Size(430, 45);
            this.CboxMdP.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 37);
            this.label8.TabIndex = 53;
            this.label8.Text = "Metodo de Pago:";
            // 
            // CboxCdC
            // 
            this.CboxCdC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboxCdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxCdC.FormattingEnabled = true;
            this.CboxCdC.Items.AddRange(new object[] {
            "Ventas",
            "Producción",
            "Inversiones",
            "Pasivos",
            "Servicios",
            "Oficina"});
            this.CboxCdC.Location = new System.Drawing.Point(454, 550);
            this.CboxCdC.Name = "CboxCdC";
            this.CboxCdC.Size = new System.Drawing.Size(430, 45);
            this.CboxCdC.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 37);
            this.label7.TabIndex = 51;
            this.label7.Text = "Centro de Costos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "Categoria de Transaccion:";
            // 
            // TxtBoxCudT
            // 
            this.TxtBoxCudT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCudT.Location = new System.Drawing.Point(454, 412);
            this.TxtBoxCudT.Name = "TxtBoxCudT";
            this.TxtBoxCudT.Size = new System.Drawing.Size(430, 44);
            this.TxtBoxCudT.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 37);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cuenta de Transaccion:";
            // 
            // TxtBoxMdT
            // 
            this.TxtBoxMdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxMdT.Location = new System.Drawing.Point(454, 337);
            this.TxtBoxMdT.Name = "TxtBoxMdT";
            this.TxtBoxMdT.Size = new System.Drawing.Size(430, 44);
            this.TxtBoxMdT.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 37);
            this.label3.TabIndex = 46;
            this.label3.Text = "Monto de Transaccion:";
            // 
            // TxtBoxDdT
            // 
            this.TxtBoxDdT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDdT.Location = new System.Drawing.Point(454, 177);
            this.TxtBoxDdT.Multiline = true;
            this.TxtBoxDdT.Name = "TxtBoxDdT";
            this.TxtBoxDdT.Size = new System.Drawing.Size(596, 143);
            this.TxtBoxDdT.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "Descripcion de Transaccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 37);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tipo de Transaccion:";
            // 
            // DtpFechaTransaccion
            // 
            this.DtpFechaTransaccion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaTransaccion.Location = new System.Drawing.Point(454, 63);
            this.DtpFechaTransaccion.Name = "DtpFechaTransaccion";
            this.DtpFechaTransaccion.Size = new System.Drawing.Size(205, 44);
            this.DtpFechaTransaccion.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 37);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha de Transaccion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(286, 37);
            this.label11.TabIndex = 62;
            this.label11.Text = "ID de Transaccion:";
            // 
            // TxtBoxIDTransaccion
            // 
            this.TxtBoxIDTransaccion.Enabled = false;
            this.TxtBoxIDTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxIDTransaccion.Location = new System.Drawing.Point(454, 12);
            this.TxtBoxIDTransaccion.Name = "TxtBoxIDTransaccion";
            this.TxtBoxIDTransaccion.Size = new System.Drawing.Size(430, 44);
            this.TxtBoxIDTransaccion.TabIndex = 63;
            // 
            // Update_Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 891);
            this.Controls.Add(this.TxtBoxIDTransaccion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CboxCadT);
            this.Controls.Add(this.CboxTdT);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtBoxID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CboxEdT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboxMdP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CboxCdC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBoxCudT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxMdT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxDdT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpFechaTransaccion);
            this.Controls.Add(this.label6);
            this.Name = "Update_Finanzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Finanzas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox CboxTdT;
        public System.Windows.Forms.TextBox TxtBoxDdT;
        public System.Windows.Forms.DateTimePicker DtpFechaTransaccion;
        public System.Windows.Forms.TextBox TxtBoxIDTransaccion;
        public System.Windows.Forms.ComboBox CboxCadT;
        public System.Windows.Forms.TextBox TxtBoxID;
        public System.Windows.Forms.ComboBox CboxEdT;
        public System.Windows.Forms.ComboBox CboxMdP;
        public System.Windows.Forms.ComboBox CboxCdC;
        public System.Windows.Forms.TextBox TxtBoxCudT;
        public System.Windows.Forms.TextBox TxtBoxMdT;
    }
}