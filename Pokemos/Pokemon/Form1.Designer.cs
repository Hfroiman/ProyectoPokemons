
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPokemons
            // 
            this.dgwPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPokemons.Location = new System.Drawing.Point(12, 12);
            this.dgwPokemons.Name = "dgwPokemons";
            this.dgwPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPokemons.Size = new System.Drawing.Size(544, 209);
            this.dgwPokemons.TabIndex = 0;
            this.dgwPokemons.SelectionChanged += new System.EventHandler(this.dgwPokemons_SelectionChanged);
            // 
            // pbxpokemons
            // 
            this.pbxpokemons.Location = new System.Drawing.Point(570, 12);
            this.pbxpokemons.Name = "pbxpokemons";
            this.pbxpokemons.Size = new System.Drawing.Size(208, 208);
            this.pbxpokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpokemons.TabIndex = 1;
            this.pbxpokemons.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 233);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 268);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pbxpokemons);
            this.Controls.Add(this.dgwPokemons);
            this.Name = "Form1";
            this.Text = "Pestaña de Pokemons";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPokemons;
        private System.Windows.Forms.PictureBox pbxpokemons;
        private System.Windows.Forms.Button btnagregar;
    }
}

