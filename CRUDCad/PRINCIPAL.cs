using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCad
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void cADASTRARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroCliente c1 = new CadastroCliente();
            c1.Show();
        }

        private void pESQUISARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PESQUISAR p1 = new PESQUISAR();
            p1.Show();
        }

        private void aTUALIZARToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ATUALIZAR a1 = new ATUALIZAR();
            a1.Show();
        }

        private void eXCLUIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EXCLUIR e1 = new EXCLUIR();
            e1.Show();
        }

        private void sAIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
