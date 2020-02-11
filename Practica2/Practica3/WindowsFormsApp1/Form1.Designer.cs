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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.rbHijo = new System.Windows.Forms.RadioButton();
            this.rbRama = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtInsertar = new System.Windows.Forms.TextBox();
            this.tvwArbol = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvwLista = new System.Windows.Forms.ListView();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsertarLista = new System.Windows.Forms.Button();
            this.btnBorrarLista = new System.Windows.Forms.Button();
            this.btnBorrarTodoLista = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.colDni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 25);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(329, 482);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.gpBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBorrarTodo);
            this.tabPage1.Controls.Add(this.btnBorrar);
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.txtInsertar);
            this.tabPage1.Controls.Add(this.tvwArbol);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arbol";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gpBox
            // 
            this.gpBox.Controls.Add(this.rbHijo);
            this.gpBox.Controls.Add(this.rbRama);
            this.gpBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.gpBox.Location = new System.Drawing.Point(15, 343);
            this.gpBox.Name = "gpBox";
            this.gpBox.Size = new System.Drawing.Size(162, 50);
            this.gpBox.TabIndex = 6;
            this.gpBox.TabStop = false;
            this.gpBox.Text = "Tipo";
            // 
            // rbHijo
            // 
            this.rbHijo.AutoSize = true;
            this.rbHijo.Location = new System.Drawing.Point(98, 19);
            this.rbHijo.Name = "rbHijo";
            this.rbHijo.Size = new System.Drawing.Size(43, 17);
            this.rbHijo.TabIndex = 1;
            this.rbHijo.TabStop = true;
            this.rbHijo.Text = "Hijo";
            this.rbHijo.UseVisualStyleBackColor = true;
            // 
            // rbRama
            // 
            this.rbRama.AutoSize = true;
            this.rbRama.Location = new System.Drawing.Point(7, 20);
            this.rbRama.Name = "rbRama";
            this.rbRama.Size = new System.Drawing.Size(53, 17);
            this.rbRama.TabIndex = 0;
            this.rbRama.TabStop = true;
            this.rbRama.Text = "Rama";
            this.rbRama.UseVisualStyleBackColor = true;
            this.rbRama.CheckedChanged += new System.EventHandler(this.rbRama_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(173, 399);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(135, 23);
            this.btnBorrarTodo.TabIndex = 4;
            this.btnBorrarTodo.Text = "Borrar Todo el Árbol";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(15, 399);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(223, 317);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtInsertar
            // 
            this.txtInsertar.Location = new System.Drawing.Point(15, 317);
            this.txtInsertar.Name = "txtInsertar";
            this.txtInsertar.Size = new System.Drawing.Size(162, 20);
            this.txtInsertar.TabIndex = 1;
            // 
            // tvwArbol
            // 
            this.tvwArbol.Location = new System.Drawing.Point(15, 43);
            this.tvwArbol.Name = "tvwArbol";
            this.tvwArbol.Size = new System.Drawing.Size(293, 241);
            this.tvwArbol.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnBorrarTodoLista);
            this.tabPage2.Controls.Add(this.btnBorrarLista);
            this.tabPage2.Controls.Add(this.btnInsertarLista);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.txtDni);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.lblTelefono);
            this.tabPage2.Controls.Add(this.lblDni);
            this.tabPage2.Controls.Add(this.lvwLista);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(239, 528);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvwLista
            // 
            this.lvwLista.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDni,
            this.colNombre,
            this.colTelefono});
            this.lvwLista.FullRowSelect = true;
            this.lvwLista.GridLines = true;
            this.lvwLista.HideSelection = false;
            this.lvwLista.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvwLista.Location = new System.Drawing.Point(31, 50);
            this.lvwLista.Name = "lvwLista";
            this.lvwLista.Size = new System.Drawing.Size(261, 154);
            this.lvwLista.TabIndex = 0;
            this.lvwLista.UseCompatibleStateImageBehavior = false;
            this.lvwLista.UseWaitCursor = true;
            this.lvwLista.View = System.Windows.Forms.View.Details;
            this.lvwLista.SelectedIndexChanged += new System.EventHandler(this.lvwLista_SelectedIndexChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(28, 299);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(28, 379);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 339);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(84, 299);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 336);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(124, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 372);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(223, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icono";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnInsertarLista
            // 
            this.btnInsertarLista.Location = new System.Drawing.Point(223, 358);
            this.btnInsertarLista.Name = "btnInsertarLista";
            this.btnInsertarLista.Size = new System.Drawing.Size(75, 23);
            this.btnInsertarLista.TabIndex = 8;
            this.btnInsertarLista.Text = "Insertar";
            this.btnInsertarLista.UseVisualStyleBackColor = true;
            this.btnInsertarLista.Click += new System.EventHandler(this.btnInsertarLista_Click);
            // 
            // btnBorrarLista
            // 
            this.btnBorrarLista.Location = new System.Drawing.Point(28, 427);
            this.btnBorrarLista.Name = "btnBorrarLista";
            this.btnBorrarLista.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarLista.TabIndex = 9;
            this.btnBorrarLista.Text = "Borrar";
            this.btnBorrarLista.UseVisualStyleBackColor = true;
            this.btnBorrarLista.Click += new System.EventHandler(this.btnBorrarLista_Click);
            // 
            // btnBorrarTodoLista
            // 
            this.btnBorrarTodoLista.Location = new System.Drawing.Point(178, 427);
            this.btnBorrarTodoLista.Name = "btnBorrarTodoLista";
            this.btnBorrarTodoLista.Size = new System.Drawing.Size(120, 23);
            this.btnBorrarTodoLista.TabIndex = 10;
            this.btnBorrarTodoLista.Text = "Borrar toda la lista";
            this.btnBorrarTodoLista.UseVisualStyleBackColor = true;
            this.btnBorrarTodoLista.Click += new System.EventHandler(this.btnBorrarTodoLista_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.ImageIndex = 0;
            this.radioButton1.ImageList = this.imageList1;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.ImageIndex = 1;
            this.radioButton2.ImageList = this.imageList1;
            this.radioButton2.Location = new System.Drawing.Point(7, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // colDni
            // 
            this.colDni.Text = "DNI";
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            // 
            // colTelefono
            // 
            this.colTelefono.Text = "Telefono";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Whack-Windows-Live-Messenger-icon.png");
            this.imageList1.Images.SetKeyName(1, "Office-Girl-icon.png");
            this.imageList1.Images.SetKeyName(2, "windows-7-user-icon.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 563);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Form1";
            this.Text = "Arbol y Lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.TreeView tvwArbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.RadioButton rbHijo;
        private System.Windows.Forms.RadioButton rbRama;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ListView lvwLista;
        private System.Windows.Forms.Button btnBorrarTodoLista;
        private System.Windows.Forms.Button btnBorrarLista;
        private System.Windows.Forms.Button btnInsertarLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ColumnHeader colDni;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colTelefono;
        private System.Windows.Forms.ImageList imageList1;
    }
}

