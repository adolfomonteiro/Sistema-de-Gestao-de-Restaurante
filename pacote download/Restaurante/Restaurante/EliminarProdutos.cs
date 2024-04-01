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
    public partial class EliminarProdutos : Form
    {
        public EliminarProdutos()
        {
            InitializeComponent();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Campo Vazio!");
            }
            else
            {
                base_dados bd = new base_dados();
                bd.EliminarProduto(int.Parse(txtId.Text));
                txtId.Text = "";
                string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

                MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,subcategoria,preco,quantidade from Produtos", string_conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dadosProduto.DataSource = tabela;
            }
        }

        private void EliminarProdutos_Load(object sender, EventArgs e)
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,categoria,subcategoria,preco,quantidade from Produtos", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dadosProduto.DataSource = tabela;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            string texto = txtId.Text;
            Home h = new Home(texto);
            this.Hide();
            h.ShowDialog();
        }
    }
}
