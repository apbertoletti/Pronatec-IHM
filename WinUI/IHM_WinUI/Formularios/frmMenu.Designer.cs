namespace Formularios
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMalaDiretaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbCategoriaProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbFornecedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGerarArquivo = new System.Windows.Forms.ToolStripButton();
            this.tsbAlterarSenha = new System.Windows.Forms.ToolStripButton();
            this.tsbMalaDireta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.utilitariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444259796_free_17;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
            this.clientesToolStripMenuItem.Text = "Cli&entes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444260332_Label;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444261182_category;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(248, 38);
            this.fornecedoresToolStripMenuItem.Text = "Cate&gorias de produto";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444261255_suppliers;
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(208, 38);
            this.fornecedorToolStripMenuItem.Text = "&Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // utilitariosToolStripMenuItem
            // 
            this.utilitariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarArquivoToolStripMenuItem,
            this.alterarSenhaDeAcessoToolStripMenuItem,
            this.enviarMalaDiretaToolStripMenuItem});
            this.utilitariosToolStripMenuItem.Name = "utilitariosToolStripMenuItem";
            this.utilitariosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitariosToolStripMenuItem.Text = "&Utilitarios";
            // 
            // gerarArquivoToolStripMenuItem
            // 
            this.gerarArquivoToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444262800_folder;
            this.gerarArquivoToolStripMenuItem.Name = "gerarArquivoToolStripMenuItem";
            this.gerarArquivoToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.gerarArquivoToolStripMenuItem.Text = "&Gerar arquivo";
            this.gerarArquivoToolStripMenuItem.Click += new System.EventHandler(this.gerarArquivoToolStripMenuItem_Click);
            // 
            // alterarSenhaDeAcessoToolStripMenuItem
            // 
            this.alterarSenhaDeAcessoToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444262714_unlock;
            this.alterarSenhaDeAcessoToolStripMenuItem.Name = "alterarSenhaDeAcessoToolStripMenuItem";
            this.alterarSenhaDeAcessoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.alterarSenhaDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.alterarSenhaDeAcessoToolStripMenuItem.Text = "&Alterar senha de acesso";
            this.alterarSenhaDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaDeAcessoToolStripMenuItem_Click);
            // 
            // enviarMalaDiretaToolStripMenuItem
            // 
            this.enviarMalaDiretaToolStripMenuItem.Image = global::Formularios.Properties.Resources._1444871677_Email;
            this.enviarMalaDiretaToolStripMenuItem.Name = "enviarMalaDiretaToolStripMenuItem";
            this.enviarMalaDiretaToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.enviarMalaDiretaToolStripMenuItem.Text = "&Enviar mala direta";
            this.enviarMalaDiretaToolStripMenuItem.Click += new System.EventHandler(this.enviarMalaDiretaToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simulando um tratamento de erro que possa ser evitado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1444259796_free-17.ico");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCliente,
            this.tsbProduto,
            this.tsbCategoriaProduto,
            this.tsbFornecedor,
            this.toolStripSeparator1,
            this.tsbGerarArquivo,
            this.tsbAlterarSenha,
            this.tsbMalaDireta,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(456, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCliente
            // 
            this.tsbCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCliente.Image = global::Formularios.Properties.Resources._1444259796_free_17;
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(36, 36);
            this.tsbCliente.Text = "Cadastro de Clientes";
            this.tsbCliente.Click += new System.EventHandler(this.tsbCliente_Click);
            // 
            // tsbProduto
            // 
            this.tsbProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProduto.Image = global::Formularios.Properties.Resources._1444260332_Label;
            this.tsbProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProduto.Name = "tsbProduto";
            this.tsbProduto.Size = new System.Drawing.Size(36, 36);
            this.tsbProduto.Text = "Cadastro de produtos";
            this.tsbProduto.Click += new System.EventHandler(this.tsbProduto_Click);
            // 
            // tsbCategoriaProduto
            // 
            this.tsbCategoriaProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCategoriaProduto.Image = global::Formularios.Properties.Resources._1444261182_category;
            this.tsbCategoriaProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategoriaProduto.Name = "tsbCategoriaProduto";
            this.tsbCategoriaProduto.Size = new System.Drawing.Size(36, 36);
            this.tsbCategoriaProduto.Text = "toolStripButton3";
            this.tsbCategoriaProduto.ToolTipText = "Cadastro de categorias de produtos";
            this.tsbCategoriaProduto.Click += new System.EventHandler(this.tsbCategoriaProduto_Click);
            // 
            // tsbFornecedor
            // 
            this.tsbFornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFornecedor.Image = global::Formularios.Properties.Resources._1444261255_suppliers;
            this.tsbFornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFornecedor.Name = "tsbFornecedor";
            this.tsbFornecedor.Size = new System.Drawing.Size(36, 36);
            this.tsbFornecedor.Text = "toolStripButton4";
            this.tsbFornecedor.ToolTipText = "Cadastro de fornecedores";
            this.tsbFornecedor.Click += new System.EventHandler(this.tsbFornecedor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbGerarArquivo
            // 
            this.tsbGerarArquivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGerarArquivo.Image = global::Formularios.Properties.Resources._1444262800_folder;
            this.tsbGerarArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGerarArquivo.Name = "tsbGerarArquivo";
            this.tsbGerarArquivo.Size = new System.Drawing.Size(36, 36);
            this.tsbGerarArquivo.Text = "Gerar arquivo";
            this.tsbGerarArquivo.Click += new System.EventHandler(this.tsbGerarArquivo_Click);
            // 
            // tsbAlterarSenha
            // 
            this.tsbAlterarSenha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlterarSenha.Image = global::Formularios.Properties.Resources._1444262714_unlock;
            this.tsbAlterarSenha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlterarSenha.Name = "tsbAlterarSenha";
            this.tsbAlterarSenha.Size = new System.Drawing.Size(36, 36);
            this.tsbAlterarSenha.Text = "toolStripButton6";
            this.tsbAlterarSenha.ToolTipText = "Trocar senha de acesso";
            this.tsbAlterarSenha.Click += new System.EventHandler(this.tsbAlterarSenha_Click);
            // 
            // tsbMalaDireta
            // 
            this.tsbMalaDireta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMalaDireta.Image = global::Formularios.Properties.Resources._1444871677_Email;
            this.tsbMalaDireta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMalaDireta.Name = "tsbMalaDireta";
            this.tsbMalaDireta.Size = new System.Drawing.Size(36, 36);
            this.tsbMalaDireta.Text = "tsbMalaDireta";
            this.tsbMalaDireta.ToolTipText = "Enviar mala direta";
            this.tsbMalaDireta.Click += new System.EventHandler(this.tsbMalaDireta_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem utilitariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripButton tsbProduto;
        private System.Windows.Forms.ToolStripButton tsbCategoriaProduto;
        private System.Windows.Forms.ToolStripButton tsbFornecedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGerarArquivo;
        private System.Windows.Forms.ToolStripButton tsbAlterarSenha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem enviarMalaDiretaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbMalaDireta;
    }
}