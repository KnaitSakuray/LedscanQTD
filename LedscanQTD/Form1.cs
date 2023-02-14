using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LedscanQTD
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String UpdateQTD = "";

        private void Update()
        {
            //Abre conexão com o  banco
            SqlConnection conm = new SqlConnection(Conexao.ROTA);
            SqlCommand comande1 = new SqlCommand(@"UPDATE [ROTA].dbo.[API_NF] SET [N_Qtd] = @QTD WHERE N_Nota_Fiscal=@NOTA AND [N_Modelo]=@MOD ", conm);

            //cada um com sua variável
            comande1.Parameters.Add("@MOD", SqlDbType.VarChar).Value = textBox2.Text;
            comande1.Parameters.Add("@NOTA", SqlDbType.VarChar).Value = textBox1.Text;
            comande1.Parameters.Add("@QTD", SqlDbType.Int).Value = Convert.ToInt32(UpdateQTD);

            conm.Open();
            comande1.ExecuteScalar();

            //Fecha Conexão com o banco
            conm.Close();
            MessageBox.Show("Quantidade Atualizado com sucesso!");
        }
        // botão para atualização da quatidade 
        private void tbupdate_Click(object sender, EventArgs e)
        {
            UpdateQTD = textBox3.Text.Trim();
            Update();
            textBox3.Clear();
        }
        
        // textBox do modelo e N°NF
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
