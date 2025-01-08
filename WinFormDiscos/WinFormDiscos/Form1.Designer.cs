namespace WinFormDiscos
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(22, 37);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(814, 232);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(842, 37);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(355, 385);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 1;
            this.pbxDisco.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Button btnAgregar;
    }
}

