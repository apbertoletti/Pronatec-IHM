using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeusControles
{
    public partial class MeuBotao : UserControl
    {
        public MeuBotao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja carregar todos os registros?", "Dados", MessageBoxButtons.YesNo);
        }
    }
}
