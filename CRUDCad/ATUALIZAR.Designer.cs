namespace CRUDCad
{
    partial class ATUALIZAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATUALIZAR));
            this.txtTURMA = new System.Windows.Forms.TextBox();
            this.labelTURMA = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.labelNOME = new System.Windows.Forms.Label();
            this.labelRA = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESQUISARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCLUIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoAlterar = new System.Windows.Forms.Button();
            this.txtPesquisaRA = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTURMA
            // 
            this.txtTURMA.Location = new System.Drawing.Point(26, 270);
            this.txtTURMA.Name = "txtTURMA";
            this.txtTURMA.Size = new System.Drawing.Size(105, 20);
            this.txtTURMA.TabIndex = 13;
            // 
            // labelTURMA
            // 
            this.labelTURMA.AutoSize = true;
            this.labelTURMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTURMA.Location = new System.Drawing.Point(25, 236);
            this.labelTURMA.Name = "labelTURMA";
            this.labelTURMA.Size = new System.Drawing.Size(66, 20);
            this.labelTURMA.TabIndex = 12;
            this.labelTURMA.Text = "TURMA";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(26, 186);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(106, 20);
            this.txtNOME.TabIndex = 11;
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOME.Location = new System.Drawing.Point(23, 154);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(56, 20);
            this.labelNOME.TabIndex = 10;
            this.labelNOME.Text = "NOME";
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRA.Location = new System.Drawing.Point(23, 54);
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(32, 20);
            this.labelRA.TabIndex = 8;
            this.labelRA.Text = "RA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.pESQUISARToolStripMenuItem,
            this.aTUALIZARToolStripMenuItem,
            this.eXCLUIRToolStripMenuItem});
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cRUDToolStripMenuItem.Text = "CRUD";
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            this.cADASTRARToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARToolStripMenuItem_Click);
            // 
            // pESQUISARToolStripMenuItem
            // 
            this.pESQUISARToolStripMenuItem.Name = "pESQUISARToolStripMenuItem";
            this.pESQUISARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pESQUISARToolStripMenuItem.Text = "PESQUISAR";
            this.pESQUISARToolStripMenuItem.Click += new System.EventHandler(this.pESQUISARToolStripMenuItem_Click);
            // 
            // aTUALIZARToolStripMenuItem
            // 
            this.aTUALIZARToolStripMenuItem.Name = "aTUALIZARToolStripMenuItem";
            this.aTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aTUALIZARToolStripMenuItem.Text = "ATUALIZAR";
            // 
            // eXCLUIRToolStripMenuItem
            // 
            this.eXCLUIRToolStripMenuItem.Name = "eXCLUIRToolStripMenuItem";
            this.eXCLUIRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXCLUIRToolStripMenuItem.Text = "EXCLUIR";
            this.eXCLUIRToolStripMenuItem.Click += new System.EventHandler(this.eXCLUIRToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Location = new System.Drawing.Point(214, 51);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(111, 25);
            this.botaoPesquisar.TabIndex = 15;
            this.botaoPesquisar.Text = "PESQUISAR";
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(348, 52);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(134, 24);
            this.botaoLimpar.TabIndex = 18;
            this.botaoLimpar.Text = "LIMPAR CAMPOS";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // botaoAlterar
            // 
            this.botaoAlterar.Location = new System.Drawing.Point(301, 251);
            this.botaoAlterar.Name = "botaoAlterar";
            this.botaoAlterar.Size = new System.Drawing.Size(163, 39);
            this.botaoAlterar.TabIndex = 19;
            this.botaoAlterar.Text = "ALTERAR";
            this.botaoAlterar.UseVisualStyleBackColor = true;
            this.botaoAlterar.Click += new System.EventHandler(this.botaoAlterar_Click);
            // 
            // txtPesquisaRA
            // 
            this.txtPesquisaRA.Location = new System.Drawing.Point(61, 56);
            this.txtPesquisaRA.Name = "txtPesquisaRA";
            this.txtPesquisaRA.Size = new System.Drawing.Size(136, 20);
            this.txtPesquisaRA.TabIndex = 20;
            // 
            // ATUALIZAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Controls.Add(this.txtPesquisaRA);
            this.Controls.Add(this.botaoAlterar);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.txtTURMA);
            this.Controls.Add(this.labelTURMA);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.labelRA);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ATUALIZAR";
            this.Text = "ATUALIZAR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTURMA;
        private System.Windows.Forms.Label labelTURMA;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.Label labelRA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESQUISARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCLUIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.Button botaoPesquisar;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoAlterar;
        private System.Windows.Forms.TextBox txtPesquisaRA;
    }
}