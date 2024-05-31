namespace Estafeta.Formularios
{
    partial class Logistica
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
            this.DgvTablaPyM = new System.Windows.Forms.DataGridView();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaPyM)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaPyM
            // 
            this.DgvTablaPyM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaPyM.Location = new System.Drawing.Point(21, 71);
            this.DgvTablaPyM.Name = "DgvTablaPyM";
            this.DgvTablaPyM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvTablaPyM.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTablaPyM.Size = new System.Drawing.Size(633, 378);
            this.DgvTablaPyM.TabIndex = 0;
            this.DgvTablaPyM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTablaPyE_CellMouseDoubleClick);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Insertar.Location = new System.Drawing.Point(674, 71);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(209, 46);
            this.Btn_Insertar.TabIndex = 1;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = true;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logística";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(674, 149);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(209, 46);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Logistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 482);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.DgvTablaPyM);
            this.Name = "Logistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistica";
            this.Load += new System.EventHandler(this.Logistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaPyM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Insertar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DgvTablaPyM;
        private System.Windows.Forms.Button BtnEliminar;
    }
}