using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Cash_1._0_with_SQL
{
    public partial class frmGerente : Form
    {
        public frmGerente()
        {
            InitializeComponent();
        }
        protected void button1_Click(object sender, EventArgs e)
        {
            if (txtLogiGerente.Text == "100" && txtSenhagerente.Text == "9494")
            {
                frmCadastroFuncionario y = new frmCadastroFuncionario();
                y.Show();
            }
            else
                MessageBox.Show("Somente o gerente pode fazer essa operação!");
        }
    }
}
