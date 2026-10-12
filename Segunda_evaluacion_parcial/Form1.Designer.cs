namespace Segunda_evaluacion_parcial
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtxCategoria = new System.Windows.Forms.Label();
            this.txtxPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtexistencias = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtExxistencias = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(209, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 16);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre del producto";
            this.txtNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtxCategoria
            // 
            this.txtxCategoria.AutoSize = true;
            this.txtxCategoria.Location = new System.Drawing.Point(213, 129);
            this.txtxCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtxCategoria.Name = "txtxCategoria";
            this.txtxCategoria.Size = new System.Drawing.Size(66, 16);
            this.txtxCategoria.TabIndex = 1;
            this.txtxCategoria.Text = "Categoria";
            // 
            // txtxPrecio
            // 
            this.txtxPrecio.AutoSize = true;
            this.txtxPrecio.Location = new System.Drawing.Point(213, 183);
            this.txtxPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtxPrecio.Name = "txtxPrecio";
            this.txtxPrecio.Size = new System.Drawing.Size(46, 16);
            this.txtxPrecio.TabIndex = 2;
            this.txtxPrecio.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(417, 68);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(132, 22);
            this.txtproducto.TabIndex = 4;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(417, 129);
            this.txtcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(132, 22);
            this.txtcategoria.TabIndex = 5;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(417, 174);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(132, 22);
            this.txtprecio.TabIndex = 6;
            // 
            // txtexistencias
            // 
            this.txtexistencias.Location = new System.Drawing.Point(417, 223);
            this.txtexistencias.Margin = new System.Windows.Forms.Padding(4);
            this.txtexistencias.Name = "txtexistencias";
            this.txtexistencias.Size = new System.Drawing.Size(132, 22);
            this.txtexistencias.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(599, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(455, 185);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtExxistencias
            // 
            this.txtExxistencias.AutoSize = true;
            this.txtExxistencias.Location = new System.Drawing.Point(213, 231);
            this.txtExxistencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtExxistencias.Name = "txtExxistencias";
            this.txtExxistencias.Size = new System.Drawing.Size(78, 16);
            this.txtExxistencias.TabIndex = 10;
            this.txtExxistencias.Text = "Existencias ";
            this.txtExxistencias.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(111, 384);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(100, 28);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(303, 384);
            this.btnconsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(100, 28);
            this.btnconsultar.TabIndex = 12;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(491, 384);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(100, 28);
            this.btnactualizar.TabIndex = 13;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(692, 384);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(891, 384);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.Text = "Limpiardor";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtExxistencias);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtexistencias);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtxPrecio);
            this.Controls.Add(this.txtxCategoria);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtxCategoria;
        private System.Windows.Forms.Label txtxPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtexistencias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtExxistencias;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

