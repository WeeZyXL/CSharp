namespace EstruturaCondicional
{
    partial class Form3
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
            this.TITULO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.ckbx1 = new System.Windows.Forms.CheckBox();
            this.ckbx2 = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITULO.ForeColor = System.Drawing.Color.White;
            this.TITULO.Location = new System.Drawing.Point(80, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(164, 45);
            this.TITULO.TabIndex = 0;
            this.TITULO.Text = "Checkbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preço da Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço Total";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(146, 87);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(136, 20);
            this.txtvalor.TabIndex = 3;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(146, 122);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(136, 20);
            this.txttotal.TabIndex = 4;
            // 
            // ckbx1
            // 
            this.ckbx1.AutoSize = true;
            this.ckbx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbx1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckbx1.ForeColor = System.Drawing.Color.White;
            this.ckbx1.Location = new System.Drawing.Point(71, 155);
            this.ckbx1.Name = "ckbx1";
            this.ckbx1.Size = new System.Drawing.Size(188, 23);
            this.ckbx1.TabIndex = 5;
            this.ckbx1.Text = "Borda Recheada R$ 2,00";
            this.ckbx1.UseVisualStyleBackColor = true;
            // 
            // ckbx2
            // 
            this.ckbx2.AutoSize = true;
            this.ckbx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbx2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.ckbx2.ForeColor = System.Drawing.Color.White;
            this.ckbx2.Location = new System.Drawing.Point(71, 183);
            this.ckbx2.Name = "ckbx2";
            this.ckbx2.Size = new System.Drawing.Size(207, 23);
            this.ckbx2.TabIndex = 6;
            this.ckbx2.Text = "Refrigerante Fanta R$ 5,00";
            this.ckbx2.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(106, 221);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 31);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(315, 297);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ckbx2);
            this.Controls.Add(this.ckbx1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TITULO);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.CheckBox ckbx1;
        private System.Windows.Forms.CheckBox ckbx2;
        private System.Windows.Forms.Button btnCalcular;
    }
}