namespace EstruturaCondicional
{
    partial class Form2
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
            this.lblres = new System.Windows.Forms.Label();
            this.txtresposta = new System.Windows.Forms.TextBox();
            this.rdbtn1 = new System.Windows.Forms.RadioButton();
            this.rdbrn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn3 = new System.Windows.Forms.RadioButton();
            this.btnSelec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio Button";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.White;
            this.lblres.Location = new System.Drawing.Point(82, 144);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(111, 30);
            this.lblres.TabIndex = 1;
            this.lblres.Text = "Resposta:";
            // 
            // txtresposta
            // 
            this.txtresposta.Location = new System.Drawing.Point(199, 153);
            this.txtresposta.Name = "txtresposta";
            this.txtresposta.Size = new System.Drawing.Size(122, 20);
            this.txtresposta.TabIndex = 2;
            // 
            // rdbtn1
            // 
            this.rdbtn1.AutoSize = true;
            this.rdbtn1.BackColor = System.Drawing.Color.Transparent;
            this.rdbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn1.ForeColor = System.Drawing.Color.White;
            this.rdbtn1.Location = new System.Drawing.Point(66, 216);
            this.rdbtn1.Name = "rdbtn1";
            this.rdbtn1.Size = new System.Drawing.Size(72, 30);
            this.rdbtn1.TabIndex = 3;
            this.rdbtn1.TabStop = true;
            this.rdbtn1.Text = "Java";
            this.rdbtn1.UseVisualStyleBackColor = false;
            // 
            // rdbrn2
            // 
            this.rdbrn2.AutoSize = true;
            this.rdbrn2.BackColor = System.Drawing.Color.Transparent;
            this.rdbrn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbrn2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbrn2.ForeColor = System.Drawing.Color.White;
            this.rdbrn2.Location = new System.Drawing.Point(190, 216);
            this.rdbrn2.Name = "rdbrn2";
            this.rdbrn2.Size = new System.Drawing.Size(57, 30);
            this.rdbrn2.TabIndex = 4;
            this.rdbrn2.TabStop = true;
            this.rdbrn2.Text = "C#";
            this.rdbrn2.UseVisualStyleBackColor = false;
            // 
            // rdbtn3
            // 
            this.rdbtn3.AutoSize = true;
            this.rdbtn3.BackColor = System.Drawing.Color.Transparent;
            this.rdbtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn3.ForeColor = System.Drawing.Color.White;
            this.rdbtn3.Location = new System.Drawing.Point(313, 216);
            this.rdbtn3.Name = "rdbtn3";
            this.rdbtn3.Size = new System.Drawing.Size(65, 30);
            this.rdbtn3.TabIndex = 5;
            this.rdbtn3.TabStop = true;
            this.rdbtn3.Text = "PHP";
            this.rdbtn3.UseVisualStyleBackColor = false;
            // 
            // btnSelec
            // 
            this.btnSelec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelec.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSelec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelec.ForeColor = System.Drawing.Color.White;
            this.btnSelec.Location = new System.Drawing.Point(168, 267);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(100, 35);
            this.btnSelec.TabIndex = 6;
            this.btnSelec.Text = "Selecionar";
            this.btnSelec.UseVisualStyleBackColor = false;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(451, 346);
            this.Controls.Add(this.btnSelec);
            this.Controls.Add(this.rdbtn3);
            this.Controls.Add(this.rdbrn2);
            this.Controls.Add(this.rdbtn1);
            this.Controls.Add(this.txtresposta);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.TextBox txtresposta;
        private System.Windows.Forms.RadioButton rdbtn1;
        private System.Windows.Forms.RadioButton rdbrn2;
        private System.Windows.Forms.RadioButton rdbtn3;
        private System.Windows.Forms.Button btnSelec;
    }
}