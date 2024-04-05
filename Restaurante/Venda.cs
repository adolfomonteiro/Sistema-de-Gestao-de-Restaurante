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
using System.IO;

namespace Restaurante
{
    public partial class Venda : Form
    {
        private Image imagemRecebida;
        private int totaldeEntrada = 0;
        private int totaldeSaida = 0 ;
        public Venda(Image imagem, string nome, string categoria, int preco)
        {
            InitializeComponent();
            imagemRecebida = imagem;
            txtNome.Text = nome;
            txtCategoria.Text = categoria;
            txtPreco.Text = preco.ToString();
        }
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Venda_Load(object sender, EventArgs e)
        {
            FotoPrato.Image = imagemRecebida;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int contador = totaldeSaida + 1;
            int cont = totaldeEntrada + 1;

            string minhaConexao = "server=localhost;user=root;database=restaurante;Sslmode=none;pwd=";

            try { 
            MySqlConnection conexao = new MySqlConnection(minhaConexao);
            conexao.Open();

            MySqlDataAdapter adaptador = new MySqlDataAdapter($"insert into venda values(default,'{txtNome.Text}','{int.Parse(txtPreco.Text)}');", minhaConexao);
            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);
                MessageBox.Show("Dados Adicionado Com Sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("\n", ex.ToString());
            }
           
           Vender formEstoque = Application.OpenForms["Vender"] as Vender;
            if(formEstoque != null){
                formEstoque.AdicionarPrecoVendido(cont, contador);
            }
            else
            {
                MessageBox.Show("Formulário de Estoque não está aberto!");
            }
            this.Close();
        }
    }
}
