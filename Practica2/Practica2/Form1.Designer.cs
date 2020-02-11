namespace Practica2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblIdiomas = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtAddchk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.chckIdiomas = new System.Windows.Forms.CheckedListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBorrarLista = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre.Location = new System.Drawing.Point(46, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCiudad.Location = new System.Drawing.Point(46, 276);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(73, 22);
            this.lblCiudad.TabIndex = 1;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblIdiomas
            // 
            this.lblIdiomas.AutoSize = true;
            this.lblIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIdiomas.Location = new System.Drawing.Point(46, 365);
            this.lblIdiomas.Name = "lblIdiomas";
            this.lblIdiomas.Size = new System.Drawing.Size(78, 22);
            this.lblIdiomas.TabIndex = 2;
            this.lblIdiomas.Text = "Idiomas";
            this.lblIdiomas.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDireccion.Location = new System.Drawing.Point(46, 173);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(94, 22);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFoto.Location = new System.Drawing.Point(446, 92);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(50, 22);
            this.lblFoto.TabIndex = 4;
            this.lblFoto.Text = "Foto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(63, 212);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(237, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtAddchk
            // 
            this.txtAddchk.Location = new System.Drawing.Point(200, 545);
            this.txtAddchk.Name = "txtAddchk";
            this.txtAddchk.Size = new System.Drawing.Size(151, 20);
            this.txtAddchk.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ficha Personal";
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Badajoz",
            "Cáceres",
            "Mérida",
            "Almendralejo"});
            this.cbCiudad.Location = new System.Drawing.Point(63, 312);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(196, 21);
            this.cbCiudad.TabIndex = 9;
            this.cbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbCiudad_SelectedIndexChanged);
            // 
            // chckIdiomas
            // 
            this.chckIdiomas.FormattingEnabled = true;
            this.chckIdiomas.Items.AddRange(new object[] {
            "Ingles",
            "Francés",
            "Italiano",
            "Alemán"});
            this.chckIdiomas.Location = new System.Drawing.Point(50, 406);
            this.chckIdiomas.Name = "chckIdiomas";
            this.chckIdiomas.Size = new System.Drawing.Size(301, 94);
            this.chckIdiomas.TabIndex = 10;
            this.chckIdiomas.SelectedIndexChanged += new System.EventHandler(this.chckIdiomas_SelectedIndexChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAñadir.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAñadir.Location = new System.Drawing.Point(51, 543);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(96, 22);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBorrar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrar.Location = new System.Drawing.Point(51, 585);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(96, 22);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBorrarLista
            // 
            this.btnBorrarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBorrarLista.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarLista.Location = new System.Drawing.Point(212, 585);
            this.btnBorrarLista.Name = "btnBorrarLista";
            this.btnBorrarLista.Size = new System.Drawing.Size(139, 22);
            this.btnBorrarLista.TabIndex = 13;
            this.btnBorrarLista.Text = "Borrar Lista";
            this.btnBorrarLista.UseVisualStyleBackColor = true;
            this.btnBorrarLista.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(465, 393);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 26);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnValidar.ForeColor = System.Drawing.Color.Black;
            this.btnValidar.Location = new System.Drawing.Point(465, 438);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(96, 24);
            this.btnValidar.TabIndex = 15;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(465, 478);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 22);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSobre.ForeColor = System.Drawing.Color.Black;
            this.btnSobre.Location = new System.Drawing.Point(465, 524);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(96, 22);
            this.btnSobre.TabIndex = 17;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(465, 572);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 22);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(450, 140);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(111, 92);
            this.picFoto.TabIndex = 19;
            this.picFoto.TabStop = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInsertar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInsertar.Location = new System.Drawing.Point(434, 276);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(139, 22);
            this.btnInsertar.TabIndex = 20;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "\"\"";
            this.ofdFoto.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 632);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnBorrarLista);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.chckIdiomas);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddchk);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblIdiomas);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblIdiomas;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtAddchk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.CheckedListBox chckIdiomas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBorrarLista;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}

