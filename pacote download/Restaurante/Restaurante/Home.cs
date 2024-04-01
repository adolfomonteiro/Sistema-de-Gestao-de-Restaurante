using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Home : Form
    {
        public Home(string texto)
        {
            InitializeComponent();
            Funcionario.Text = texto;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           string textoDigitado = txtNome.Text;
           Home h = new Home(textoDigitado);

            PaginaInicial.Show();
            ContaGerente.Hide();
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
            AdicionarProdutos a = new AdicionarProdutos();
            this.Hide();
            a.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            VerProdutos v = new VerProdutos();
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

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
            p.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Image imagem = guna2Button4.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.ShowDialog();
        }

        private void btn_Comidas_Click(object sender, EventArgs e)
        {
            Image imagem = btn_Comidas.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.ShowDialog();
        }

        private void btn_Bebidas_Click(object sender, EventArgs e)
        {
            Image imagem = btn_Bebidas.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.ShowDialog();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Image imagem = btn_Estoque.Image;
            Vender v = new Vender(imagem);
            this.Hide();
            v.ShowDialog();
        }
    }
}
