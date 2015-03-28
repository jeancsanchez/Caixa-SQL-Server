using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Simple_Cash_1._0_with_SQL;

namespace Simple_Cash_1._0_with_SQL.Model
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public void CadastrarProduto(Produto produto)
        {
            SqlConnection on = new SqlConnection(Conexao.StringConection);
            SqlCommand cm = new SqlCommand("insert into produtos values(@Nome,@preco)", on);
            cm.Parameters.AddWithValue("@nome", produto.Nome);
            cm.Parameters.AddWithValue("@preco", produto.Preco);

            try
            {
                on.Open();
                cm.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                on.Close();
            }
        }
    }
}
