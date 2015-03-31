using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Simple_Cash_1._0_with_SQL.Model;

namespace Simple_Cash_1._0_with_SQL
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDeDadosCashDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.bancoDeDadosCashDataSet.Produtos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNomeProduto.Text;
            produto.Preco = Convert.ToSingle(txtPrecoProduto.Text);

            Funcionario funcionario = new Funcionario();
            funcionario.CadastrarProduto(produto);

            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection on = new SqlConnection(Conexao.StringConection);
            SqlCommand cm = new SqlCommand("select*from produtos", on);
            DataTable dt = new DataTable();

            try
            {
                on.Open();
                SqlDataReader dr = cm.ExecuteReader();
                dt.Load(dr);
                if (dr.FieldCount < 1)
                    MessageBox.Show("Produto não existe!");
                da.Update(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                on.Close();
            }
        }
    }
}
