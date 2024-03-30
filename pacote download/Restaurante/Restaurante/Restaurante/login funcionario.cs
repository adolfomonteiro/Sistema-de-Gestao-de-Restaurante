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

namespace Restaurante
{
    public partial class login_funcionario : Form 
    {
        public login_funcionario()
        {
            InitializeComponent();
        }

        private void login_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox == Ocultar)
            {
                // Configura a TextBox para ocultar o texto
                txtSenha.UseSystemPasswordChar = true;
            }
            else if (pictureBox == Ver)
            {
                // Configura a TextBox para mostrar o texto
                txtSenha.UseSystemPasswordChar = false;
            }

        }
        

        private void Ver_Click(object sender, EventArgs e)
        {
            bool password = txtSenha.UseSystemPasswordChar;
            txtSenha.UseSystemPasswordChar = false;

            string texto = txtSenha.Text;
            txtSenha.UseSystemPasswordChar = password;


            Ver.Visible = false;
            Ocultar.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Cadastrar_Funcionarios c = new Cadastrar_Funcionarios();
            this.Hide();
            c.ShowDialog();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            try
            {
                if(txtNome.Text != "" && txtSenha.Text != "")
                {
                    string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

                    string Nome = txtNome.Text;
                    string Senha = txtSenha.Text;
                    bool verificar = false;
                  
                    MySqlConnection ligacao = new MySqlConnection(string_conexao);
                    ligacao.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM cad_funcionarios", string_conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    foreach (DataRow linha in tabela.Rows)
                    {
                        if(linha["nome"].ToString() == Nome && linha["senha"].ToString()== Senha)
                        {
                            verificar = true;
                            break;
                        }
                        else
                        {
                            verificar = false;
                        }
                    }
                    if(verificar == true)
                    {
                        string textoDigitado = txtNome.Text;
                        
                        Home h = new Home(textoDigitado);
                        this.Hide();
                        h.ShowDialog();
                        txtNome.Text = string.Empty;
                        txtSenha.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Crie uma Conta");
                    }
                }
                else if(txtNome.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha Todos Campos Vazios!!!");
                }
                else if(txtNome.Text == "")
                {
                    MessageBox.Show("Coloque o Nome");
                }
                else if(txtSenha.Text == "")
                {
                    MessageBox.Show("Coloque a Senha");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);     
            }
           
        }
    }
}
