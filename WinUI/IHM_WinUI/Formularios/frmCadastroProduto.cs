using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formularios
{
    /** AULA 2: immplementação de herança visual para padronização das telas **/
    public partial class frmCadastroProduto : frmBase
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        //AULA 8: Sobreescreve o método SalvaRegistroBD() que está no form base 
        //e implementanta suas validações específicas aqui
        protected override bool SalvaRegistroBD()
        {
            //AULA 8: Validações
            if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo descrição é obrigatório");
                return false; //AULA 8: Interrrompe a execução do método nesta linha
            }

            if (txtDescricao.Text.Trim().Length > 40)
            {
                MessageBox.Show("O campo descrição deve ter no máximo 40 caracteres");
                return false; 
            }

            if (txtValor.Text.Trim() == string.Empty || Convert.ToDecimal(txtValor.Text) < 0)
            {
                MessageBox.Show("O campo valor deve ser maior do que zero.");
                return false;  
            }

            //1) Cria a conexao com o BD
            //2) Acessa a tabela necessaria
            //3) Insere o registro na tabela
            //4) Salva tudo

            MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            //AULA 8: Faz a validação do controle usando seu evento Validating
            if (txtValor.Text.Trim() == string.Empty || Convert.ToDecimal(txtValor.Text) < 0)
            {
                e.Cancel = true; //Ativa o cancelamento, ou seja, este controle (txtValor) está INVÁLIDO
                errorProvider1.SetError(txtValor, "O campo valor deve ser maior do que zero.");
            }
            else
                errorProvider1.Clear(); //Limpa o erro do controle (txtValor), caso esteja válido
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            //AULA 8: Seta o tamanhao máximo do controle via propriedade MaxLength
            txtDescricao.MaxLength = 40;
        }
    }
}
