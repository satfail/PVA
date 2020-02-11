namespace Practica2
{
    partial class regform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rbAcepto = new System.Windows.Forms.RadioButton();
            this.rbRechazo = new System.Windows.Forms.RadioButton();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licencia del Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Location = new System.Drawing.Point(29, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(242, 90);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Contrato por licienca\nEl siguiente producto contiene\nbla\nbla bla\nbla ,bla\nbla,bla" +
    ",bla\n..............................";
            // 
            // rbAcepto
            // 
            this.rbAcepto.AutoSize = true;
            this.rbAcepto.Location = new System.Drawing.Point(37, 242);
            this.rbAcepto.Name = "rbAcepto";
            this.rbAcepto.Size = new System.Drawing.Size(59, 17);
            this.rbAcepto.TabIndex = 3;
            this.rbAcepto.TabStop = true;
            this.rbAcepto.Text = "Acepto";
            this.rbAcepto.UseVisualStyleBackColor = true;
            this.rbAcepto.CheckedChanged += new System.EventHandler(this.rbAcepto_CheckedChanged);
            // 
            // rbRechazo
            // 
            this.rbRechazo.AutoSize = true;
            this.rbRechazo.Location = new System.Drawing.Point(37, 277);
            this.rbRechazo.Name = "rbRechazo";
            this.rbRechazo.Size = new System.Drawing.Size(68, 17);
            this.rbRechazo.TabIndex = 4;
            this.rbRechazo.TabStop = true;
            this.rbRechazo.Text = "Rechazo";
            this.rbRechazo.UseVisualStyleBackColor = true;
            this.rbRechazo.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(62, 341);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(111, 23);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(232, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(391, 390);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.rbRechazo);
            this.Controls.Add(this.rbAcepto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "regform";
            this.Text = "regform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rbAcepto;
        private System.Windows.Forms.RadioButton rbRechazo;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}