namespace Formularios
{
    partial class frmMalaDireta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMalaDireta));
            this.lstDisponiveis = new System.Windows.Forms.ListBox();
            this.lstSelecionados = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirSomenteOSelecionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.limparLixeiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLixeira = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisponiveis
            // 
            this.lstDisponiveis.FormattingEnabled = true;
            this.lstDisponiveis.Location = new System.Drawing.Point(20, 94);
            this.lstDisponiveis.Name = "lstDisponiveis";
            this.lstDisponiveis.Size = new System.Drawing.Size(204, 147);
            this.lstDisponiveis.TabIndex = 0;
            this.lstDisponiveis.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstDisponiveis_MouseDown);
            // 
            // lstSelecionados
            // 
            this.lstSelecionados.AllowDrop = true;
            this.lstSelecionados.ContextMenuStrip = this.contextMenuStrip2;
            this.lstSelecionados.FormattingEnabled = true;
            this.lstSelecionados.Location = new System.Drawing.Point(268, 94);
            this.lstSelecionados.Name = "lstSelecionados";
            this.lstSelecionados.Size = new System.Drawing.Size(204, 147);
            this.lstSelecionados.TabIndex = 1;
            this.lstSelecionados.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstSelecionados_DragDrop);
            this.lstSelecionados.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstSelecionados_DragEnter);
            this.lstSelecionados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstSelecionados_MouseDown);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirSomenteOSelecionadoToolStripMenuItem,
            this.excluirTodosToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(234, 48);
            // 
            // excluirSomenteOSelecionadoToolStripMenuItem
            // 
            this.excluirSomenteOSelecionadoToolStripMenuItem.Name = "excluirSomenteOSelecionadoToolStripMenuItem";
            this.excluirSomenteOSelecionadoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.excluirSomenteOSelecionadoToolStripMenuItem.Text = "Excluir somente o selecionado";
            this.excluirSomenteOSelecionadoToolStripMenuItem.Click += new System.EventHandler(this.excluirSomenteOSelecionadoToolStripMenuItem_Click);
            // 
            // excluirTodosToolStripMenuItem
            // 
            this.excluirTodosToolStripMenuItem.Name = "excluirTodosToolStripMenuItem";
            this.excluirTodosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.excluirTodosToolStripMenuItem.Text = "Excluir todos";
            this.excluirTodosToolStripMenuItem.Click += new System.EventHandler(this.excluirTodosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes disponíveis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes selecionados:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(276, 417);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 53);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(381, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 53);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 63);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(230, 127);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(32, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = ">";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(230, 182);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(32, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "<";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparLixeiraToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // limparLixeiraToolStripMenuItem
            // 
            this.limparLixeiraToolStripMenuItem.Name = "limparLixeiraToolStripMenuItem";
            this.limparLixeiraToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.limparLixeiraToolStripMenuItem.Text = "Limpar lixeira";
            this.limparLixeiraToolStripMenuItem.Click += new System.EventHandler(this.limparLixeiraToolStripMenuItem_Click);
            // 
            // lblLixeira
            // 
            this.lblLixeira.AllowDrop = true;
            this.lblLixeira.ContextMenuStrip = this.contextMenuStrip1;
            this.lblLixeira.Image = global::Formularios.Properties.Resources.imgLixeiraVazia;
            this.lblLixeira.Location = new System.Drawing.Point(356, 262);
            this.lblLixeira.Name = "lblLixeira";
            this.lblLixeira.Size = new System.Drawing.Size(124, 133);
            this.lblLixeira.TabIndex = 1;
            this.lblLixeira.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblLixeira_DragDrop);
            this.lblLixeira.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblLixeira_DragEnter);
            // 
            // frmMalaDireta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 482);
            this.Controls.Add(this.lblLixeira);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSelecionados);
            this.Controls.Add(this.lstDisponiveis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMalaDireta";
            this.Text = "Envio de Mala Direta para Clientes";
            this.Load += new System.EventHandler(this.frmMalaDireta_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisponiveis;
        private System.Windows.Forms.ListBox lstSelecionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblLixeira;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem limparLixeiraToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem excluirSomenteOSelecionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTodosToolStripMenuItem;
    }
}