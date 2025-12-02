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
    public partial class CadastrarCrianca : Form
    {

        static string conexao = "Server=127.0.0.1;Port=3306;Database=Natal;Uid=root;Pwd='' ;"; // trocar a porta de 3307 para 3306 no senai
        Crianca c1 = new Crianca();
        string idade;

        public CadastrarCrianca()
        {
            InitializeComponent();
        }

        private void CadastrarCrianca_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipal principal = new TelaPrincipal();
            principal.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c1.nome = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            idade = textBox2.Text;
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
            if (Bomzinho_True.Checked)
                c1.bomzinho = false;
        }

        private void Cadastrar_Crianca_Click(object sender, EventArgs e)
        {
            c1.idade = int.Parse(idade);
            if (cadastrar_crianca(c1))
            {
                MessageBox.Show("Criança Cadastrad Com Sucesso!");
                this.Close();
            }
        }

        private static bool cadastrar_crianca(Crianca c1)
        {
            try
            {
                using(MySqlConnection con = new MySqlConnection(conexao))
                {
                        con.Open();

                        string query = @"insert into crianca (nome, idade, genero, bomzinho) values (@nome, @idade, @genero, @bomzinho) ;";

                        MySqlCommand cmd = new MySqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@nome", c1.nome);
                        cmd.Parameters.AddWithValue("@idade", c1.idade);
                        cmd.Parameters.AddWithValue("@genero", c1.genero);
                        cmd.Parameters.AddWithValue("@bomzinho", c1.bomzinho);

                        cmd.ExecuteNonQuery();

                        con.Close();
                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro: {ex.Message}");
                return false;
            }

        }
    }
}
