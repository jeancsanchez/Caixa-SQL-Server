namespace Simple_Cash_1._0_with_SQL
{
    partial class frmGerente
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
            this.txtLogiGerente = new System.Windows.Forms.TextBox();
            this.txtSenhagerente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogiGerente
            // 
            this.txtLogiGerente.Location = new System.Drawing.Point(47, 42);
            this.txtLogiGerente.Name = "txtLogiGerente";
            this.txtLogiGerente.Size = new System.Drawing.Size(100, 20);
            this.txtLogiGerente.TabIndex = 0;
            // 
            // txtSenhagerente
            // 
            this.txtSenhagerente.Location = new System.Drawing.Point(47, 88);
            this.txtSenhagerente.Name = "txtSenhagerente";
            this.txtSenhagerente.PasswordChar = '*';
            this.txtSenhagerente.Size = new System.Drawing.Size(100, 20);
            this.txtSenhagerente.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código do gerente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // frmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSenhagerente);
            this.Controls.Add(this.txtLogiGerente);
            this.Name = "frmGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtLogiGerente;
        protected System.Windows.Forms.TextBox txtSenhagerente;
        protected System.Windows.Forms.Button button1;
    }
}