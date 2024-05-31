namespace Estafeta.Formularios
{
    partial class RecursosHumanos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTablaRH = new System.Windows.Forms.DataGridView();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaRH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recursos Humanos";
            // 
            // DgvTablaRH
            // 
            this.DgvTablaRH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaRH.Location = new System.Drawing.Point(19, 61);
            this.DgvTablaRH.Name = "DgvTablaRH";
            this.DgvTablaRH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvTablaRH.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTablaRH.Size = new System.Drawing.Size(789, 378);
            this.DgvTablaRH.TabIndex = 4;
            this.DgvTablaRH.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTablaRH_CellMouseDoubleClick);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Insertar.Location = new System.Drawing.Point(829, 61);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(209, 46);
            this.Btn_Insertar.TabIndex = 5;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(829, 130);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(209, 46);
            this.Btn_Eliminar.TabIndex = 6;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // RecursosHumanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 466);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.DgvTablaRH);
            this.Controls.Add(this.label1);
            this.Name = "RecursosHumanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecursosHumanos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaRH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvTablaRH;
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}