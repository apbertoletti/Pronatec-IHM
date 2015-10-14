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
            MostraFormCliente();
        }

        //AULA 10: Foi criado uma método único para exibir form, o qual será chamado por dois lugares diferentes. 
        //Esta é uma boa prática para se fazer reaproveitamento de código
        private void MostraFormCliente()
        {
            frmCadastroCliente fCliente = new frmCadastroCliente();
            fCliente.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostraFormProduto();
        }

        //AULA 10: Foi criado uma método único para exibir form, o qual será chamado por dois lugares diferentes. 
        //Esta é uma boa prática para se fazer reaproveitamento de código
        private void MostraFormProduto()
        {
            frmCadastroProduto fProduto = new frmCadastroProduto();
            fProduto.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostraFormCategoria();
        }

        //AULA 10: Foi criado uma método único para exibir form, o qual será chamado por dois lugares diferentes. 
        //Esta é uma boa prática para se fazer reaproveitamento de código
        private void MostraFormCategoria()
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
            MostraGeraArquivo();
        }

        //AULA 10: Foi criado uma método único para exibir form, o qual será chamado por dois lugares diferentes. 
        //Esta é uma boa prática para se fazer reaproveitamento de código
        private void MostraGeraArquivo()
        {
            frmGerarArquivo f = new frmGerarArquivo();
            f.ShowDialog();
        }

        private void alterarSenhaDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostraMudaSenha();
        }

        //AULA 10: Foi criado uma método único para exibir form, o qual será chamado por dois lugares diferentes. 
        //Esta é uma boa prática para se fazer reaproveitamento de código
        private void MostraMudaSenha()
        {
            frmMudaSenha f = new frmMudaSenha();
            f.ShowDialog();
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            MostraFormCliente();
        }

        private void tsbProduto_Click(object sender, EventArgs e)
        {
            MostraFormProduto();        
        }

        private void tsbCategoriaProduto_Click(object sender, EventArgs e)
        {
            MostraFormCategoria();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostraFornecedor();
        }

        //AULA 10: Foi criado uma método único para exibir form, o qual será chamado por dois lugares diferentes. 
        //Esta é uma boa prática para se fazer reaproveitamento de código
        private void MostraFornecedor()
        {
            frmCadFornecedor f = new frmCadFornecedor();
            f.ShowDialog();
        }

        private void tsbFornecedor_Click(object sender, EventArgs e)
        {
            MostraFornecedor();
        }

        private void tsbGerarArquivo_Click(object sender, EventArgs e)
        {
            MostraGeraArquivo();
        }

        private void tsbAlterarSenha_Click(object sender, EventArgs e)
        {
            MostraMudaSenha();
        }

        private void enviarMalaDiretaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostraMalaDireta();
        }

        private void MostraMalaDireta()
        {
            frmMalaDireta f = new frmMalaDireta();
            f.ShowDialog();
        }

        private void tsbMalaDireta_Click(object sender, EventArgs e)
        {
            MostraMalaDireta();
        }
    }
}
