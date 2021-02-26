
namespace ClienteEscCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconsulta = new System.Windows.Forms.Button();
            this.btnconsultaC = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconsulta
            // 
            this.btnconsulta.Location = new System.Drawing.Point(145, 132);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(178, 23);
            this.btnconsulta.TabIndex = 0;
            this.btnconsulta.Text = "Consultar Todo";
            this.btnconsulta.UseVisualStyleBackColor = true;
            this.btnconsulta.Click += new System.EventHandler(this.btnconsulta_Click);
            // 
            // btnconsultaC
            // 
            this.btnconsultaC.Location = new System.Drawing.Point(494, 132);
            this.btnconsultaC.Name = "btnconsultaC";
            this.btnconsultaC.Size = new System.Drawing.Size(153, 23);
            this.btnconsultaC.TabIndex = 1;
            this.btnconsultaC.Text = "Consulta por Ciudad";
            this.btnconsultaC.UseVisualStyleBackColor = true;
            this.btnconsultaC.Click += new System.EventHandler(this.btnconsultaC_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(49, 208);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(670, 217);
            this.dgvReporte.TabIndex = 2;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(312, 40);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.btnconsultaC);
            this.Controls.Add(this.btnconsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.Button btnconsultaC;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.TextBox txtCiudad;
    }
}

