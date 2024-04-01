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
    public partial class AdicionarProdutos : Form
    {

       

        public AdicionarProdutos(Vender vender)
        {
            InitializeComponent();
        }
        
        public class MinhaClasse{

           private Vender vender;
        public MinhaClasse()
            {
                Image image = Image.FromFile("");
                vender = new Vender(image);
            }
    }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
          string  texto = "Funcionário";
            Home h = new Home(texto);
            this.Hide();
            h.ShowDialog();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";
            string produto = txtNome.Text;
        
            if (txtNome.Text == "" && txtCategoria.Text == "" && txtPreco.Text=="" && txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha Tudo!");
            }
            else if(txtNome.Text == "")
            {
                MessageBox.Show("Coloque o Nome Do Produto!");
            }
            else if (txtCategoria.Text == "")
            {
                MessageBox.Show("Coloque a Categoria!");
            }
            else if(txtPreco.Text == "")
            {
                MessageBox.Show("Coloque o Preço do Produto!");
            }
            else if(txtQuantidade.Text == "")
            {
                MessageBox.Show("Coloque a Quantidade de Produto!");
            }
            else
            {
                MySqlConnection ligacao = new MySqlConnection(string_conexao);
                ligacao.Open();

                var input = ligacao.CreateCommand();
                input.CommandText = $"INSERT INTO Produtos VALUES(default,'{txtNome.Text}','{txtCategoria.Text}','{txtPreco.Text}','{txtQuantidade.Text}');";
                input.ExecuteNonQuery();

                Limpar();       
            }
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,preco,quantidade from Produtos", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtCategoria.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
        }

        private void AdicionarProdutos_Load(object sender, EventArgs e)
        {

            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,preco,quantidade from Produtos", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }
    }
}
