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
    public partial class VerProdutos : Form
    {
        public VerProdutos()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string texto = "";
            Home h = new Home(texto);
            this.Hide();
            h.ShowDialog();
        }

        private void VerProdutos_Load(object sender, EventArgs e)
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,subcategoria,preco,quantidade from Produtos", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }
    }
}
