using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Home : Form
    {
        public event EventHandler ComidaClicked;
        public event EventHandler BebidaClicked;
        public Vender vender;
        public Home(string texto)
        {
            InitializeComponent();
            Funcionario.Text = texto;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            PaginaInicial.Show();
            ContaGerente.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            login_funcionario f = new login_funcionario();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            login_funcionario f = new login_funcionario();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_PaginaInicial_Click(object sender, EventArgs e)
        {
            PaginaInicial.Show();
            ContaGerente.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Gerente_Click(object sender, EventArgs e)
        {
            ContaGerente.Show();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            AdicionarProdutos a = new AdicionarProdutos(vender);
            this.Hide();
            a.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            VerProdutos v = new VerProdutos();
            this.Hide();
            v.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarProdutos el = new EliminarProdutos();
            this.Hide();
            el.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EditarProdutos ed = new EditarProdutos();
            this.Hide();
            ed.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Pesquisar_Produtos p = new Pesquisar_Produtos();
            this.Hide();
            p.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Image imagem = pictureBox10.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.Show();
        }

        private void btn_Comidas_Click(object sender, EventArgs e)
        {
            ComidaClicked?.Invoke(this, EventArgs.Empty);
           /* Image imagem = btn_Comidas.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.Show();*/
        }

        private void btn_Bebidas_Click(object sender, EventArgs e)
        {
            BebidaClicked?.Invoke(this, EventArgs.Empty);
           /* Image imagem = btn_Bebidas.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.ShowDialog();*/
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Image imagem = btn_Estoque.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.ShowDialog();
        }

        private void Esqueci_Click(object sender, EventArgs e)
        {
            SenhaGestor s = new SenhaGestor();
            this.Hide();
            s.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Gestor g = new Gestor();
            this.Hide();
            g.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "" && txtSenha.Text != "")
                {
                    string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

                    string Nome = txtNome.Text;
                    string Senha = txtSenha.Text;
                    bool verificar = false;

                    MySqlConnection ligacao = new MySqlConnection(string_conexao);
                    ligacao.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT * FROM gestor", string_conexao);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    foreach (DataRow linha in tabela.Rows)
                    {
                        if (linha["nome"].ToString() == Nome && linha["senha"].ToString() == Senha)
                        {
                            verificar = true;
                            break;
                        }
                        else
                        {
                            verificar = false;
                        }
                    }
                    if (verificar == true)
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
                        MessageBox.Show("Esta Conta não existe ! Crie uma Conta");
                    }
                }
                else if (txtNome.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha Todos Campos Vazios!!!");
                }
                else if (txtNome.Text == "")
                {
                    MessageBox.Show("Coloque o Nome");
                }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Coloque a Senha");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            string url = "http://127.0.0.1:5500/facebook/index.html";
            Process.Start(url);
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            FormEstoque v = new FormEstoque();
            this.Hide();
            v.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FormEstoque v = new FormEstoque();
            this.Hide();
            v.ShowDialog();
        }
    }
}
