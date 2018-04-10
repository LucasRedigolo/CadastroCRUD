namespace CRUDCad
{
    partial class PRINCIPAL
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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(73, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "SELECIONE A OPÇÃO DESEJADA NO MENU ACIMA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 8;
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
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.cRUDToolStripMenuItem.Text = "MENU";
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            this.cADASTRARToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARToolStripMenuItem_Click_1);
            // 
            // pESQUISARToolStripMenuItem
            // 
            this.pESQUISARToolStripMenuItem.Name = "pESQUISARToolStripMenuItem";
            this.pESQUISARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pESQUISARToolStripMenuItem.Text = "PESQUISAR";
            this.pESQUISARToolStripMenuItem.Click += new System.EventHandler(this.pESQUISARToolStripMenuItem_Click_1);
            // 
            // aTUALIZARToolStripMenuItem
            // 
            this.aTUALIZARToolStripMenuItem.Name = "aTUALIZARToolStripMenuItem";
            this.aTUALIZARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aTUALIZARToolStripMenuItem.Text = "ATUALIZAR";
            this.aTUALIZARToolStripMenuItem.Click += new System.EventHandler(this.aTUALIZARToolStripMenuItem_Click_1);
            // 
            // eXCLUIRToolStripMenuItem
            // 
            this.eXCLUIRToolStripMenuItem.Name = "eXCLUIRToolStripMenuItem";
            this.eXCLUIRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eXCLUIRToolStripMenuItem.Text = "EXCLUIR";
            this.eXCLUIRToolStripMenuItem.Click += new System.EventHandler(this.eXCLUIRToolStripMenuItem_Click_1);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click_1);
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(716, 436);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Name = "PRINCIPAL";
            this.Text = "PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESQUISARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTUALIZARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCLUIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}