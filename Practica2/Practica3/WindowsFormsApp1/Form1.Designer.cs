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
            this.tabPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPrincipal.Controls.Add(this.tabPage1);
            this.tabPrincipal.Controls.Add(this.tabPage2);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 34);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(329, 470);
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
            this.tabPage1.Size = new System.Drawing.Size(321, 444);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 563);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Form1";
            this.Text = "Arbol y Lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
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
    }
}

