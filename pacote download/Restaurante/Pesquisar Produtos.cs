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
    public partial class Pesquisar_Produtos : Form
    {
        public Pesquisar_Produtos()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            string texto = txtNome.Text;
            Home h = new Home(texto);
            this.Hide();
            h.ShowDialog();
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            base_dados db = new base_dados();
            db.PesquisarProduto(txtNome.Text);

            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

            MySqlDataAdapter adaptador = new MySqlDataAdapter($"SELECT *FROM Produtos WHERE nome like '%{txtNome.Text}%'", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }

        private void Pesquisar_Produtos_Load(object sender, EventArgs e)
        {

        }
    }
}
