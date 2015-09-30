using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmMudaSenha : Form
    {
        public frmMudaSenha()
        {
            InitializeComponent();
        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            //AULA 8: Validação em tempo real, conforme o usuário vai digitando.
            //Pra isso, basta utilizar o evento TextChanged do controle.
            if (SenhaForte(txtNovaSenha.Text))
            {
                txtNovaSenha.BackColor = Color.LightGreen;
            }
            else
            {
                txtNovaSenha.BackColor = Color.PaleVioletRed;
            }
        }

        private bool SenhaForte(string senha)
        {
            bool possuiPeloMenos1Simbolo = false;
            bool possuiPeloMenos1Numero = false;
            bool minimo6caracteres = false;

            if (senha.Length >= 6)
                minimo6caracteres = true;

            foreach (char c in senha)
                if (c == '@' || c == '#' || c == '$' || c == '%' || c == '&' || c == '*') 
                    possuiPeloMenos1Simbolo = true;

            foreach (char c in senha)
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    possuiPeloMenos1Numero = true;

            return (possuiPeloMenos1Numero && possuiPeloMenos1Simbolo && minimo6caracteres);
        }
    }
}
