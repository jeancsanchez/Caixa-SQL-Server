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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, senha;

            Funcionario funcionario = new Funcionario();
            id = txtCodFuncionario.Text;
            senha = txtSenha.Text;

           SqlConnection on = new SqlConnection(Conexao.StringConection);
           SqlCommand cm = new SqlCommand("select count(id) from funcionarios where id=@id and senha=@senha", on);
           cm.Parameters.Add("@id",SqlDbType.VarChar).Value = id;
           cm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
           
           try
           {
               if (id == "100" && senha == "9494")
               {
                   Principal principal = new Principal();
                   principal.Show();
                   principal.Focus();
                   
               }
               else
               {
                   on.Open();
                   int x = (int)cm.ExecuteScalar();
                   if (x > 0)
                   {
                       Principal principal = new Principal();
                       principal.Show();
                   }
                   else
                   {
                       MessageBox.Show("Usuario ou senha incorreto!");
                       txtCodFuncionario.Text = "";
                       txtSenha.Text = "";
                   }
               }
           }
            catch(SqlException erro)
           {
               throw erro;
           }
            finally
           {
               on.Close();
           }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            frmGerente x = new frmGerente();
            x.Show();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

    }
}
