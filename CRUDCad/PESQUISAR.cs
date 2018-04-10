using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCad
{
    public partial class PESQUISAR : Form
    {
        public PESQUISAR()
        {
            InitializeComponent();
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CRUD;Data Source=DESKTOP-2OJO8IK");
            SqlCommand command = new SqlCommand("select * from Alunos where IDaluno=@IDaluno", sqlCon);
            command.Parameters.Add("@IDaluno", SqlDbType.Int).Value = txtPesquisaRA.Text;

            try
            {
                sqlCon.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("RA não encontrado!!!");
                }
                dr.Read();
                txtRA.Text = Convert.ToString(dr["IDaluno"]);
                txtNOME.Text = Convert.ToString(dr["Nome"]);
                txtTURMA.Text = Convert.ToString(dr["Turma"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente c1 = new CadastroCliente();
            c1.Show();

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            txtNOME.Clear();
            txtRA.Clear();
            txtTURMA.Clear();
            txtPesquisaRA.Clear();
        }

        private void pESQUISARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ATUALIZAR a1 = new ATUALIZAR();
            a1.Show();
        }

        private void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXCLUIR e1 = new EXCLUIR();
            e1.Show();
        }
    }
}
