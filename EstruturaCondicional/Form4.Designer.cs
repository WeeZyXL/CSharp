namespace EstruturaCondicional
{
    partial class Form4
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
            this.Titulo = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.cmbxestado = new System.Windows.Forms.ComboBox();
            this.cmbxcidade = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(270, 53);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(228, 49);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "COMBOBOX";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidade.Location = new System.Drawing.Point(197, 245);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(75, 26);
            this.lblcidade.TabIndex = 1;
            this.lblcidade.Text = "Cidade:";
            this.lblcidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(197, 192);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(78, 26);
            this.lblestado.TabIndex = 2;
            this.lblestado.Text = "Estado:";
            // 
            // cmbxestado
            // 
            this.cmbxestado.FormattingEnabled = true;
            this.cmbxestado.Items.AddRange(new object[] {
            "São Paulo",
            "Minas Gerais",
            "Rio de Janeiro"});
            this.cmbxestado.Location = new System.Drawing.Point(281, 192);
            this.cmbxestado.Name = "cmbxestado";
            this.cmbxestado.Size = new System.Drawing.Size(230, 21);
            this.cmbxestado.TabIndex = 3;
            // 
            // cmbxcidade
            // 
            this.cmbxcidade.FormattingEnabled = true;
            this.cmbxcidade.Location = new System.Drawing.Point(281, 250);
            this.cmbxcidade.Name = "cmbxcidade";
            this.cmbxcidade.Size = new System.Drawing.Size(230, 21);
            this.cmbxcidade.TabIndex = 4;
            this.cmbxcidade.SelectedIndexChanged += new System.EventHandler(this.cmbxcidade_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSelect.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(281, 329);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(186, 34);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbxcidade);
            this.Controls.Add(this.cmbxestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.Titulo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cmbxestado;
        private System.Windows.Forms.ComboBox cmbxcidade;
        private System.Windows.Forms.Button btnSelect;
    }
}