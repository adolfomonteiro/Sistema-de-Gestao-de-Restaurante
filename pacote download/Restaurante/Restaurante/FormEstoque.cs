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
    public partial class FormEstoque : Form
    {
        private int totaldeEntrada = 0;
        private int totaldeSaida = 0;
        public int totalDePreco,valor_minimo;
        public static Random r = new Random();
        int valor = r.Next(0, 3);

        List<int> TodosPrecos = new List<int>()
            {
                2500,
                3500,
                3000,
                2000

            };
        public FormEstoque()
        {
            InitializeComponent();
            AdicionarPrecoVendido(totaldeEntrada, totaldeSaida);
           
        }
      
        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Estoque_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AdicionarPrecoVendido(int entradaVendida,int saidaVendida) {
            totaldeEntrada += entradaVendida;
            entrada.Text = totaldeEntrada.ToString();

            totaldeSaida += saidaVendida;
            saida.Text = totaldeSaida.ToString();
        }
        private void FormEstoque_Load(object sender, EventArgs e)
        {
            string string_conexao = "server=localhost;uid=root;database=restaurante;Sslmode=none";

           
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT nome,preco from venda", string_conexao);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dados.DataSource = tabela;
         
            int saidas = dados.Rows.Count-1;
            saida.Text = saidas.ToString();


            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT nome,preco from produtos", string_conexao);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dadosProduto.DataSource = table;

            int entradas = dadosProduto.Rows.Count - 1;
            entrada.Text = entradas.ToString();

            totalDePreco = 1500;
            valor_minimo = 3500;

            QuantidadeDePreco(valor_minimo,totalDePreco);
            AdicionarPrecoVendido(entradas, saidas);

        }
        public void QuantidadeDePreco(int valor,int preco)
        {
            int total;
            int saidas = dados.Rows.Count - 1;
           total = valor_minimo * saidas + preco;
            totalSaidas.Text = total.ToString();
        }
    }
}
