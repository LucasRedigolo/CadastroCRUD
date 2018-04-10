namespace CRUDCad
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.labelRA = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.labelNOME = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.labelTURMA = new System.Windows.Forms.Label();
            this.txtTURMA = new System.Windows.Forms.TextBox();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESQUISARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTUALIZARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCLUIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRA.Location = new System.Drawing.Point(21, 40);
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(32, 20);
            this.labelRA.TabIndex = 0;
            this.labelRA.Text = "RA";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(20, 71);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(111, 20);
            this.txtRA.TabIndex = 1;
            // 
            // labelNOME
            // 
            this.labelNOME.AutoSize = true;
            this.labelNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNOME.Location = new System.Drawing.Point(21, 122);
            this.labelNOME.Name = "labelNOME";
            this.labelNOME.Size = new System.Drawing.Size(56, 20);
            this.labelNOME.TabIndex = 2;
            this.labelNOME.Text = "NOME";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(24, 154);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(106, 20);
            this.txtNOME.TabIndex = 3;
            // 
            // labelTURMA
            // 
            this.labelTURMA.AutoSize = true;
            this.labelTURMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTURMA.Location = new System.Drawing.Point(23, 204);
            this.labelTURMA.Name = "labelTURMA";
            this.labelTURMA.Size = new System.Drawing.Size(66, 20);
            this.labelTURMA.TabIndex = 4;
            this.labelTURMA.Text = "TURMA";
            // 
            // txtTURMA
            // 
            this.txtTURMA.Location = new System.Drawing.Point(24, 238);
            this.txtTURMA.Name = "txtTURMA";
            this.txtTURMA.Size = new System.Drawing.Size(105, 20);
            this.txtTURMA.TabIndex = 5;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.Location = new System.Drawing.Point(292, 279);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(147, 37);
            this.buttonCADASTRAR.TabIndex = 6;
            this.buttonCADASTRAR.Text = "CADASTRAR";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.aTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.aTUALIZARToolStripMenuItem_Click);
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
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(549, 340);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.txtTURMA);
            this.Controls.Add(this.labelTURMA);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.labelNOME);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.labelRA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroCliente";
            this.Text = "CADASTRAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRA;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label labelNOME;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.Label labelTURMA;
        private System.Windows.Forms.TextBox txtTURMA;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESQUISARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCLUIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}

