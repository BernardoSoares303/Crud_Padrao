using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud_Padrao
{
    public partial class EditarCrianca : Form
    {
        static string conexao = "Server=127.0.0.1;Port=3306;Database=Natal;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai
        Crianca c1 = new Crianca();
        string idade;
        int id;
        string id_temporatio;

        public EditarCrianca()
        {
            InitializeComponent();
        }

        private void Editar_Crianca_Click(object sender, EventArgs e)
        {
            c1.idade = int.Parse(idade);
            id = int.Parse(id_temporatio);
            if (Editar(id, c1))
            {
                MessageBox.Show("Criança Editada Com Sucesso!");
                this.Close();
            }
        }

        private void Id_Crianca_TextChanged(object sender, EventArgs e)
        {
            id_temporatio = Id_Crianca.Text;
        }

        private void Nome_Crianca_TextChanged(object sender, EventArgs e)
        {
            c1.nome = Nome_Crianca.Text;
        }

        private void Idade_Crianca_TextChanged(object sender, EventArgs e)
        {
            idade = Idade_Crianca.Text;
        }

        private void Genero_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Masculino.Checked)
                c1.genero = 'M';
        }

        private void Genero_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Feminino.Checked)
                c1.genero = 'F';
        }

        private void Genero_Outro_CheckedChanged(object sender, EventArgs e)
        {
            if (Genero_Outro.Checked)
                c1.genero = 'O';
        }

        private void Bomzinho_True_CheckedChanged(object sender, EventArgs e)
        {
            if (Bomzinho_True.Checked)
                c1.bomzinho = true;
        }

        private void Bomzinho_False_CheckedChanged(object sender, EventArgs e)
        {
            if (Bomzinho_False.Checked)
                c1.bomzinho = false;
        }



        private static bool Editar(int id, Crianca c1)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string query = @"UPDATE crianca  SET  nome = @nome,  idade = @idade, genero = @genero, bomzinho = @bomzinho WHERE id_crianca = @id;";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", c1.nome);
                    cmd.Parameters.AddWithValue("@idade", c1.idade);
                    cmd.Parameters.AddWithValue("@genero", c1.genero);
                    cmd.Parameters.AddWithValue("@bomzinho", c1.bomzinho);
                    cmd.ExecuteNonQuery();

                    con.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }
        }
        
        private void EditarCrianca_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            principal.Show();
        }
    }
}
