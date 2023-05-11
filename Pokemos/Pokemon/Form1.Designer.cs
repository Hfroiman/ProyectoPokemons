
namespace Pokemon
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
            this.dgwPokemons = new System.Windows.Forms.DataGridView();
            this.pbxpokemons = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminacionfisica = new System.Windows.Forms.Button();
            this.btneliminarlogico = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.lblfiltrorapido = new System.Windows.Forms.Label();
            this.txtFiltrorapido = new System.Windows.Forms.TextBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxcriterio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPokemons
            // 
            this.dgwPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPokemons.Location = new System.Drawing.Point(12, 61);
            this.dgwPokemons.MultiSelect = false;
            this.dgwPokemons.Name = "dgwPokemons";
            this.dgwPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPokemons.ShowEditingIcon = false;
            this.dgwPokemons.Size = new System.Drawing.Size(544, 209);
            this.dgwPokemons.TabIndex = 0;
            this.dgwPokemons.SelectionChanged += new System.EventHandler(this.dgwPokemons_SelectionChanged);
            // 
            // pbxpokemons
            // 
            this.pbxpokemons.Location = new System.Drawing.Point(570, 61);
            this.pbxpokemons.Name = "pbxpokemons";
            this.pbxpokemons.Size = new System.Drawing.Size(208, 208);
            this.pbxpokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpokemons.TabIndex = 1;
            this.pbxpokemons.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 282);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(102, 282);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminacionfisica
            // 
            this.btneliminacionfisica.Location = new System.Drawing.Point(311, 282);
            this.btneliminacionfisica.Name = "btneliminacionfisica";
            this.btneliminacionfisica.Size = new System.Drawing.Size(108, 23);
            this.btneliminacionfisica.TabIndex = 4;
            this.btneliminacionfisica.Text = "Eliminar fisica";
            this.btneliminacionfisica.UseVisualStyleBackColor = true;
            this.btneliminacionfisica.Click += new System.EventHandler(this.btneliminacionfisica_Click);
            // 
            // btneliminarlogico
            // 
            this.btneliminarlogico.Location = new System.Drawing.Point(448, 282);
            this.btneliminarlogico.Name = "btneliminarlogico";
            this.btneliminarlogico.Size = new System.Drawing.Size(108, 23);
            this.btneliminarlogico.TabIndex = 5;
            this.btneliminarlogico.Text = "Eliminar logico";
            this.btneliminarlogico.UseVisualStyleBackColor = true;
            this.btneliminarlogico.Click += new System.EventHandler(this.btneliminarlogico_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(570, 319);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(12, 37);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(35, 13);
            this.lblfiltro.TabIndex = 7;
            this.lblfiltro.Text = "Filtro: ";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(53, 34);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(175, 20);
            this.txtfiltro.TabIndex = 8;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(17, 324);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(43, 13);
            this.lblcampo.TabIndex = 9;
            this.lblcampo.Text = "Campo:";
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(213, 327);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(45, 13);
            this.lblcriterio.TabIndex = 11;
            this.lblcriterio.Text = "Criterio: ";
            // 
            // lblfiltrorapido
            // 
            this.lblfiltrorapido.AutoSize = true;
            this.lblfiltrorapido.Location = new System.Drawing.Point(411, 324);
            this.lblfiltrorapido.Name = "lblfiltrorapido";
            this.lblfiltrorapido.Size = new System.Drawing.Size(29, 13);
            this.lblfiltrorapido.TabIndex = 12;
            this.lblfiltrorapido.Text = "Filtro";
            // 
            // txtFiltrorapido
            // 
            this.txtFiltrorapido.Location = new System.Drawing.Point(448, 321);
            this.txtFiltrorapido.Name = "txtFiltrorapido";
            this.txtFiltrorapido.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrorapido.TabIndex = 15;
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(66, 320);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 21);
            this.cbxCampo.TabIndex = 16;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxcriterio
            // 
            this.cbxcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcriterio.FormattingEnabled = true;
            this.cbxcriterio.Location = new System.Drawing.Point(264, 321);
            this.cbxcriterio.Name = "cbxcriterio";
            this.cbxcriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxcriterio.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 353);
            this.Controls.Add(this.cbxcriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.txtFiltrorapido);
            this.Controls.Add(this.lblfiltrorapido);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminarlogico);
            this.Controls.Add(this.btneliminacionfisica);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pbxpokemons);
            this.Controls.Add(this.dgwPokemons);
            this.Name = "Form1";
            this.Text = "Pestaña de Pokemons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPokemons;
        private System.Windows.Forms.PictureBox pbxpokemons;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminacionfisica;
        private System.Windows.Forms.Button btneliminarlogico;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label lblfiltrorapido;
        private System.Windows.Forms.TextBox txtFiltrorapido;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxcriterio;
    }
}

