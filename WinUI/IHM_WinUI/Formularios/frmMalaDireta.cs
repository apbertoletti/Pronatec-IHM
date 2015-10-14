using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmMalaDireta : Form
    {
        public frmMalaDireta()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (lstSelecionados.Items.Count == 0)
            {
                MessageBox.Show("É necessário selecionar pelo menos 1 (um) cliente antes de enviar os e-mais para os clientes.",
                    "Seleção de clientes inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resp =
                MessageBox.Show(
                    "Confirma o envio de email para " + lstSelecionados.Items.Count + " cliente selecionado(s)",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                Thread.Sleep(3000);
                Cursor.Current = Cursors.Default;

                MessageBox.Show("Mala direta enviada com sucesso.", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMalaDireta_Load(object sender, EventArgs e)
        {
            lstDisponiveis.Items.Add("João da Silva");
            lstDisponiveis.Items.Add("Abner Santos");
            lstDisponiveis.Items.Add("Manuel da Silva");
            lstDisponiveis.Items.Add("Teneci Fernandes");
            lstDisponiveis.Items.Add("Camila Santos do Amaral");
            lstDisponiveis.Items.Add("Maria Soares");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Captura o indice do elemento marcado no ListBox dos clientes disponíveis
            int indiceClienteMarcado = lstDisponiveis.SelectedIndex;
            
            //Verifica se algum item está marcado na lista dos clientes disponíveis
            if (indiceClienteMarcado != -1)
            {
                //Adiconar o cliente disponível marcado na lista dos clientes selecionados
                lstSelecionados.Items.Add(lstDisponiveis.Items[indiceClienteMarcado]);

                //Remove o cliente marcado da lista dos clientes disponíveis
                lstDisponiveis.Items.RemoveAt(indiceClienteMarcado);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
