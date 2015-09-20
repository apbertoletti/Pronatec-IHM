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
    public partial class frmGerarArquivo : Form
    {
        public frmGerarArquivo()
        {
            InitializeComponent();
        }

        //AULA 5: immplementação de Barra de progresso
        private void button1_Click(object sender, EventArgs e)
        {           
            int totalDeArquivos = 240;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalDeArquivos;

            int percentualAtual = 0;

            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i <= totalDeArquivos; i++)
            {
                progressBar1.Value = i;

                //Realiza do cálculo matemático para saber qual é o percentual percorrido
                //a cada iteração do laço. Em seguida, exibe o valor na label em questão.
                percentualAtual = Convert.ToInt32(Convert.ToDecimal(i) / Convert.ToDecimal(totalDeArquivos) * 100) ;
                label1.Text = percentualAtual.ToString() + "% concluído";

                //Simula a espera de 100 milisegundos a cada iteração do laço
                Thread.Sleep(100); 
                //Comando necessário para dar o refesh visual nos componetes do formulário,
                //sem ele, o valor do percentual concluido não estava aparecendo.
                Application.DoEvents();
            }
        }
    }
}
