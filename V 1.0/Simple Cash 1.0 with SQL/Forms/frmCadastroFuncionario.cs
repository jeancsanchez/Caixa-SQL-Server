using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Simple_Cash_1._0_with_SQL.Model;

namespace Simple_Cash_1._0_with_SQL
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtNome.Text;
            funcionario.Senha = txtSenha.Text;

            SqlConnection on = new SqlConnection(Conexao.StringConection);
            SqlCommand cm = new SqlCommand("insert into funcionarios values(@nome,@senha)", on);
            SqlCommand cm2 = new SqlCommand("select id from funcionarios where nome=@nome and senha=@senha",on);

            cm.Parameters.AddWithValue("@nome", funcionario.Nome);
            cm.Parameters.AddWithValue("@senha", funcionario.Senha);
            cm2.Parameters.AddWithValue("@nome", funcionario.Nome);
            cm2.Parameters.AddWithValue("@senha", funcionario.Senha);
            try
            {
                on.Open();
                cm.ExecuteNonQuery();
                string codigoFuncionario = cm2.ExecuteScalar().ToString();
                MessageBox.Show("Código do funcionario: "+codigoFuncionario);
            }
            catch(Exception erro)
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
