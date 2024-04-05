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

namespace Restaurante
{
    public partial class EditarProdutos : Form
    {
        public EditarProdutos()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string texto = txtNome.Text;
            Home h = new Home(texto);
            this.Hide();
            h.ShowDialog();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            base_dados db = new base_dados();
            db.EditarProduto(int.Parse(txtId.Text), txtNome.Text, txtCategoria.Text, txtSubcategoria.Text, int.Parse(txtPreco.Text), int.Parse(txtQuantidade.Text));
            Limpar();
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,subcategoria,preco,quantidade from Produtos", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }
        private void Limpar()
        {
            txtId.Text = "";
            txtCategoria.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtQuantidade.Text = "";
            txtSubcategoria.Text = "";
        }

        private void EditarProdutos_Load(object sender, EventArgs e)
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,subcategoria,preco,quantidade from Produtos", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }
    }
}
