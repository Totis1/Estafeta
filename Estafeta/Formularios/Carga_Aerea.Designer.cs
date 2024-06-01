namespace Estafeta.Formularios
{
    partial class Carga_Aerea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Insertar = new System.Windows.Forms.Button();
            this.DgvTablaCA = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaCA)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Eliminar.Location = new System.Drawing.Point(847, 124);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(209, 46);
            this.Btn_Eliminar.TabIndex = 12;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Insertar
            // 
            this.Btn_Insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(67)))), ((int)(((byte)(143)))));
            this.Btn_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Insertar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Insertar.Location = new System.Drawing.Point(847, 55);
            this.Btn_Insertar.Name = "Btn_Insertar";
            this.Btn_Insertar.Size = new System.Drawing.Size(209, 46);
            this.Btn_Insertar.TabIndex = 11;
            this.Btn_Insertar.Text = "Insertar";
            this.Btn_Insertar.UseVisualStyleBackColor = false;
            this.Btn_Insertar.Click += new System.EventHandler(this.Btn_Insertar_Click);
            // 
            // DgvTablaCA
            // 
            this.DgvTablaCA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTablaCA.Location = new System.Drawing.Point(19, 55);
            this.DgvTablaCA.Name = "DgvTablaCA";
            this.DgvTablaCA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvTablaCA.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvTablaCA.Size = new System.Drawing.Size(810, 491);
            this.DgvTablaCA.TabIndex = 10;
            this.DgvTablaCA.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTablaCA_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Carga Aerea";
            // 
            // Carga_Aerea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Estafeta.Properties.Resources.Estafeta_Carga_Aerea_Boeing_737_300_LDS;
            this.ClientSize = new System.Drawing.Size(1068, 561);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Insertar);
            this.Controls.Add(this.DgvTablaCA);
            this.Controls.Add(this.label1);
            this.Name = "Carga_Aerea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga_Aerea";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaCA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Insertar;
        public System.Windows.Forms.DataGridView DgvTablaCA;
        private System.Windows.Forms.Label label1;
    }
}