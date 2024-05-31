namespace Estafeta.Formularios
{
    partial class Insert_Logistica
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
            this.CBoxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // CBoxTipo
            // 
            this.CBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTipo.FormattingEnabled = true;
            this.CBoxTipo.Items.AddRange(new object[] {
            "Paquete Aereo",
            "Paquete Terrestre",
            "Mensajeria"});
            this.CBoxTipo.Location = new System.Drawing.Point(189, 16);
            this.CBoxTipo.Name = "CBoxTipo";
            this.CBoxTipo.Size = new System.Drawing.Size(226, 45);
            this.CBoxTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destino:";
            // 
            // TxtBoxDestino
            // 
            this.TxtBoxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxDestino.Location = new System.Drawing.Point(189, 93);
            this.TxtBoxDestino.Name = "TxtBoxDestino";
            this.TxtBoxDestino.Size = new System.Drawing.Size(541, 44);
            this.TxtBoxDestino.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo:";
            // 
            // TxtBoxCosto
            // 
            this.TxtBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCosto.Location = new System.Drawing.Point(189, 175);
            this.TxtBoxCosto.Name = "TxtBoxCosto";
            this.TxtBoxCosto.Size = new System.Drawing.Size(180, 44);
            this.TxtBoxCosto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CustomFormat = "yyyy-mm-dd";
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(189, 246);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(226, 44);
            this.DtpFecha.TabIndex = 7;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertar.Location = new System.Drawing.Point(610, 322);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(140, 44);
            this.BtnInsertar.TabIndex = 8;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // Insert_Logistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 403);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBoxTipo);
            this.Controls.Add(this.label1);
            this.Name = "Insert_Logistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insert_Logistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnInsertar;
    }
}