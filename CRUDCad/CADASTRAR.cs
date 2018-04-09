using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCad
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon= new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CRUD;Data Source=DESKTOP-2OJO8IK");
            SqlCommand command = new SqlCommand("insert into Alunos(IDaluno, Nome, Turma) values (@IDaluno, @Nome, @Turma)", sqlCon);
            command.Parameters.Add("@IDaluno", SqlDbType.Int).Value = txtRA.Text;
            command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNOME.Text;
            command.Parameters.Add("@Turma", SqlDbType.VarChar).Value = txtTURMA.Text;

            try{
                sqlCon.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro Efetuado Com Sucesso!");

            }
            catch (Exception ex) {
                MessageBox.Show("ERRO AO EFETUAR CADASTRO" + ex.Message);
            }
            finally{
                sqlCon.Close();
            }
        }
    }
}
