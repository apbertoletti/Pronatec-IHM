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
    //AULA 2: immplementação de herança visual para padronização das telas
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();

            //AULA 5: immplementação de Cursores de Espera
            Cursor.Current = Cursors.WaitCursor;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //AULA 6: immplementada a janela de diálogo padrão do Windows
            DialogResult resposta = MessageBox.Show("Confirma a gravação deste registro?", "Gravação",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //AULA 6: Tratamento da resposta dada pelo usuário
            if (resposta == DialogResult.Yes)
            {
                //AULA 7: Tratamento de erros
                try
                {
                    SalvaRegistroBD();
                    tabControl1.SelectedTab = tabPage1;
                    MessageBox.Show("Registro salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. \n\n" + ex.Message,
                        "Erro no BD",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }                
            }
            else if (resposta == DialogResult.No)
            {
                tabControl1.SelectedTab = tabPage1;
                MessageBox.Show("O registro em questão NÃO foi salvo!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }


        public void SalvaRegistroBD()
        {
            //Cria a conexao com o BD

            //Acessa a tabela necessaria

            throw new Exception("A estrutura da tabela cliente está desatualizada");

            //Insere o registro na tabela

            //Salva tudo
        }
    }
}
