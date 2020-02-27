namespace Vista
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
            this.grdLibros = new System.Windows.Forms.DataGridView();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbAutores = new System.Windows.Forms.ComboBox();
            this.cbEditorial = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroPaginas = new System.Windows.Forms.NumericUpDown();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPaginas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLibros
            // 
            this.grdLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLibros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grdLibros.Location = new System.Drawing.Point(12, 141);
            this.grdLibros.Name = "grdLibros";
            this.grdLibros.ReadOnly = true;
            this.grdLibros.Size = new System.Drawing.Size(730, 188);
            this.grdLibros.TabIndex = 38;
            this.grdLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLibros_CellContentClick);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DisplayMember = "nombreCategoria";
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Español ",
            "Ingles ",
            "Frances"});
            this.cbCategoria.Location = new System.Drawing.Point(646, 35);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(96, 21);
            this.cbCategoria.TabIndex = 37;
            this.cbCategoria.ValueMember = "idCategoria";
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbAutores
            // 
            this.cbAutores.DisplayMember = "autor_nombre";
            this.cbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAutores.FormattingEnabled = true;
            this.cbAutores.Items.AddRange(new object[] {
            "Español ",
            "Ingles ",
            "Frances"});
            this.cbAutores.Location = new System.Drawing.Point(360, 33);
            this.cbAutores.Name = "cbAutores";
            this.cbAutores.Size = new System.Drawing.Size(200, 21);
            this.cbAutores.TabIndex = 36;
            this.cbAutores.ValueMember = "idAutor";
            this.cbAutores.SelectedIndexChanged += new System.EventHandler(this.cbAutores_SelectedIndexChanged);
            // 
            // cbEditorial
            // 
            this.cbEditorial.DisplayMember = "nombreEditorial";
            this.cbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditorial.FormattingEnabled = true;
            this.cbEditorial.Items.AddRange(new object[] {
            "Español ",
            "Ingles ",
            "Frances"});
            this.cbEditorial.Location = new System.Drawing.Point(217, 35);
            this.cbEditorial.Name = "cbEditorial";
            this.cbEditorial.Size = new System.Drawing.Size(92, 21);
            this.cbEditorial.TabIndex = 35;
            this.cbEditorial.ValueMember = "idEditorial";
            this.cbEditorial.SelectedIndexChanged += new System.EventHandler(this.cbEditorial_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(491, 101);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 34);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Registrar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(73, 58);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(669, 37);
            this.txtDescripcion.TabIndex = 33;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(114, 33);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(45, 20);
            this.txtNumeroPaginas.TabIndex = 32;
            this.txtNumeroPaginas.ValueChanged += new System.EventHandler(this.txtNumeroPaginas_ValueChanged);
            // 
            // cbIdioma
            // 
            this.cbIdioma.DisplayMember = "1,2";
            this.cbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Items.AddRange(new object[] {
            "Español ",
            "Ingles ",
            "Frances"});
            this.cbIdioma.Location = new System.Drawing.Point(587, 11);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(155, 21);
            this.cbIdioma.TabIndex = 31;
            this.cbIdioma.SelectedIndexChanged += new System.EventHandler(this.cbIdioma_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Decripción";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Numero de paginas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Idioma";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Categoria";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Autor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Editorial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fecha de lanzamiento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(419, 11);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(117, 20);
            this.dtFecha.TabIndex = 23;
            this.dtFecha.ValueChanged += new System.EventHandler(this.dtFecha_ValueChanged);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(634, 101);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(108, 34);
            this.btnVaciar.TabIndex = 22;
            this.btnVaciar.Text = "Vaciar campos";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(45, 8);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(251, 20);
            this.txtTitulo.TabIndex = 21;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Titulo ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 349);
            this.Controls.Add(this.grdLibros);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbAutores);
            this.Controls.Add(this.cbEditorial);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPaginas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLibros;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbAutores;
        private System.Windows.Forms.ComboBox cbEditorial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown txtNumeroPaginas;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
    }
}

