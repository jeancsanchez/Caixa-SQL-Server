namespace Simple_Cash_1._0_with_SQL
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.btCadastroProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bancoDeDadosCashDataSet = new Simple_Cash_1._0_with_SQL.BancoDeDadosCashDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new Simple_Cash_1._0_with_SQL.BancoDeDadosCashDataSetTableAdapters.ProdutosTableAdapter();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.labl = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCashDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastroProduto
            // 
            this.btCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btCadastroProduto.Location = new System.Drawing.Point(12, 115);
            this.btCadastroProduto.Name = "btCadastroProduto";
            this.btCadastroProduto.Size = new System.Drawing.Size(127, 46);
            this.btCadastroProduto.TabIndex = 0;
            this.btCadastroProduto.Text = "Cadastro de produto";
            this.btCadastroProduto.UseVisualStyleBackColor = true;
            this.btCadastroProduto.Click += new System.EventHandler(this.btCadastroProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 257);
            this.dataGridView1.TabIndex = 1;
            // 
            // bancoDeDadosCashDataSet
            // 
            this.bancoDeDadosCashDataSet.DataSetName = "BancoDeDadosCashDataSet";
            this.bancoDeDadosCashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.bancoDeDadosCashDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(12, 60);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(134, 20);
            this.txtCodProduto.TabIndex = 2;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(13, 44);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(40, 13);
            this.labl.TabIndex = 3;
            this.labl.Text = "Codigo";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(376, 343);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 397);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btCadastroProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoDeDadosCashDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Principal_Load(object sender, System.EventArgs e)
        {
            txtCodProduto.Focus();
            throw new System.NotImplementedException();            
        }

        #endregion

        private System.Windows.Forms.Button btCadastroProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BancoDeDadosCashDataSet bancoDeDadosCashDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private BancoDeDadosCashDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.TextBox txtTotal;

    }
}

