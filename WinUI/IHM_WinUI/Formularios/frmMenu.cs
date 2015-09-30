using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente fCliente = new frmCadastroCliente();
            fCliente.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto fProduto = new frmCadastroProduto();
            fProduto.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCategoria fFornecedor = new frmCadCategoria();
            fFornecedor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 10;
            int c;

            //AULA 7: Tratamento de erros
            if (a != 0)
                c = b/a;
            else
            {
                MessageBox.Show("Não é possivel dividir por zero", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gerarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarArquivo f = new frmGerarArquivo();
            f.ShowDialog();
        }

        private void alterarSenhaDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMudaSenha f = new frmMudaSenha();
            f.ShowDialog();
        }
    }
}
