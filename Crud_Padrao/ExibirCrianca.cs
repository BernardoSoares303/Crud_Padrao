using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Crud_Padrao
{
    public partial class ExibirCrianca : Form
    {

        DataTable tabela;
        MySqlDataAdapter adapter;
        MySqlCommandBuilder builder;

        static string conexao = "Server=127.0.0.1;Port=3306;Database=Natal;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai


        public ExibirCrianca()
        {
            InitializeComponent();
        }

        private void ExibirCrianca_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(conexao);

                string sql = "SELECT * from crianca;";
                adapter = new MySqlDataAdapter(sql, conn);

                builder = new MySqlCommandBuilder(adapter);

                tabela = new DataTable();
                adapter.Fill(tabela);

                dataGridView1.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar: " + ex.Message);
            }
        }

        private void ExibirCrianca_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            principal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            //currentrow vai pegar a linha selecionada
            DataRowView rowView = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                                                                                     
            DataRow row = rowView.Row;

            // primeiro excluímos do datatable
            row.Delete();

            // salvamos a nova tabela [que já tem a linha excluída]
            adapter.Update(tabela);

            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
