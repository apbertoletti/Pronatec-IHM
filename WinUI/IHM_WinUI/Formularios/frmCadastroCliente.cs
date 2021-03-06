﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Formularios
{
    //AULA 2: immplementação de herança visual para padronização das telas
    public partial class frmCadastroCliente : frmBase
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //AULA 9: implementado o uso de expressões regulgares para validar o email
            Regex reg = new Regex(@"[\w-]+@([\w-]+\.)+[\w-]+");
            if (!reg.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "E-mail inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AULA 9: Uso da Propridade TextMaskFormat para configurar se deseja ou não retornar o 
            //conteúdo da máscara COM os literais
            mskCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            MessageBox.Show("O valor do campo CPF com os literais é: " + mskCPF.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AULA 9: Uso da Propridade TextMaskFormat para configurar se deseja ou não retornar o 
            //conteúdo da máscara SEM os literais
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            MessageBox.Show("O valor do campo CPF sem os literais é: " + mskCPF.Text);
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            //AULA 10: Exemplo de como utilizar o objeto OpenFileDialog que 
            //que possibilita abrir uma janela de diálogo para que o usuário escolha um arquivo qualquer
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Imagens JPG (*.jpg)|*.jpg|Imagens PNG (*.png)|*.png|Imagens GIF (*.gif)|*.gif";
            o.FilterIndex = 2;
            o.RestoreDirectory = true;

            if (o.ShowDialog() == DialogResult.OK)
                pcbFoto.Load(o.FileName);
        }
        
    }
}
