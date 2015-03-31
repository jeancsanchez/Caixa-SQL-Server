using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Cash_1._0_with_SQL
{
    public partial class Principal : Form
    {
        DataTable dt = new DataTable();
        double total = 0;
        public Principal()
        {
            InitializeComponent();
        }
        private void btCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto y = new frmCadastrarProduto();
            y.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                double preco = 0;
                int quantidade = Int32.Parse(txtQuantidade.Text);
                string cod = txtCodProduto.Text;

                SqlDataReader dr;
                SqlConnection on = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\jcnot\documents\visual studio 2013\Projects\Simple Cash 1.0 with SQL\Simple Cash 1.0 with SQL\BancoDeDadosCash.mdf;Integrated Security=True");
                SqlCommand cm = new SqlCommand("select id, nome,preco from produtos where id=@id ", on);
                SqlCommand cm2 = new SqlCommand("select preco from produtos where id=@id", on);

                cm.Parameters.AddWithValue("@id", cod);
                cm2.Parameters.AddWithValue("@id", cod);
                try
                {
                    on.Open();
                    dr = cm.ExecuteReader();
                    if (!dr.HasRows)
                        MessageBox.Show("Produto não cadastrado!");
                    else
                    {
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                            txtCodProduto.Text = "";
                            txtQuantidade.Focus();
                            preco = Convert.ToDouble(cm2.ExecuteScalar());
                            total += preco * quantidade;
                            txtTotal.Text = total.ToString();
                            txtQuantidade.Focus();
                     }
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

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (txtQuantidade.Text == "0")
                {
                    txtQuantidade.Text = 1.ToString();
                    txtCodProduto.Focus();
                }
                else
                {
                    txtCodProduto.Focus();
                }

        }
    }
}
