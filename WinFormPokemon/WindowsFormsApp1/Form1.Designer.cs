namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrarLogico = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(12, 129);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(724, 298);
            this.dgvPokemons.TabIndex = 4;
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(833, 129);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(305, 298);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 5;
            this.pbxPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 449);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(122, 29);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(295, 449);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 29);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(153, 449);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 29);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrarLogico
            // 
            this.btnBorrarLogico.Location = new System.Drawing.Point(434, 449);
            this.btnBorrarLogico.Name = "btnBorrarLogico";
            this.btnBorrarLogico.Size = new System.Drawing.Size(119, 29);
            this.btnBorrarLogico.TabIndex = 9;
            this.btnBorrarLogico.Text = "Borrar Lógico";
            this.btnBorrarLogico.UseVisualStyleBackColor = true;
            this.btnBorrarLogico.Click += new System.EventHandler(this.btnBorrarLogico_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(865, 511);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 29);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(138, 38);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(219, 20);
            this.txtfiltro.TabIndex = 11;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            this.txtfiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtrar";
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Location = new System.Drawing.Point(650, 514);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(156, 21);
            this.cbxFiltro.TabIndex = 13;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(381, 516);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(156, 21);
            this.cbxCriterio.TabIndex = 14;
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(119, 514);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(156, 21);
            this.cbxCampo.TabIndex = 15;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Criterio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Campo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnBorrarLogico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.dgvPokemons);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrarLogico;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

