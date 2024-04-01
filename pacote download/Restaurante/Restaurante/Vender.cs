using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Vender : Form
    {
        private int precoTotalEstoque = 0;
        private int totaldeEntrada = 0;
        private int totaldeSaida = 0;
        public Vender(Image image)
        {
            InitializeComponent();
            AdicionarPrecoVendido(precoTotalEstoque,totaldeSaida);
        }

        public void AdicionarPrecoVendido(int precoVendido, int saidaVendida)
        {
            precoTotalEstoque += precoVendido;
            quantidade_Vendida.Text = precoTotalEstoque.ToString();

            totaldeSaida += saidaVendida;
            saida.Text = totaldeSaida.ToString();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home h = new Home("");
            this.Hide();
            h.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Mousse ";
            string categoria = "Categoria : Comidas";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p,s);
            Image image = pictureBox1.Image;
            Venda v = new Venda(image,nome,categoria,preco);
            v.ShowDialog();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            AdicionarPrecoVendido(precoTotalEstoque, totaldeSaida);
            painel_Comidas.Show();
            panel_Bebidas.Hide();
        }

        private void btn_Comidas_Click(object sender, EventArgs e)
        {
            painel_Comidas.Show();
            panel_Bebidas.Hide();
        }

        private void btn_Bebidas_Click(object sender, EventArgs e)
        {
            panel_Bebidas.Show();
            Estoque.Hide();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Água Evian ";
            string categoria = "Categoria : Água Mineral";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox22.Image;
            Venda ve = new Venda(imagem,nome,categoria,preco);
            ve.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Carne no Espeto ";
            string categoria = "Categoria : ";
            string preco = "Preço : 2000 KZ";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox16.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Arroz Com Carne ";
            string categoria = "Categoria : Comidas";
            string preco = "Preço : 3500 KZ";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox2.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Arroz Com Feijão ";
            string categoria = "Categoria : Comidas ";
            string preco = "Preço : 3000 KZ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox3.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string nome = "Nome :  Mufete";
            string categoria = "Categoria : Cozido ";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox9.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Carne no espeto ";
            string categoria = "Categoria : Cozidos ";
            string preco = "Preço : 2000 KZ";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox18.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Bife Molhado ";
            string categoria = "Categoria : Cozidos ";
            string preco = "Preço : 3500 KZ";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox10.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Mufete ";
            string categoria = "Categoria : Cozidos";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox11.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Arroz com Feijão ";
            string categoria = "Categoria : Comidas";
            string preco = "Preço : 3000 KZ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox12.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Carne no Espeto ";
            string categoria = "Categoria : Cozidos ";
            string preco = "Preço : 2000 KZ";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p,s);
            Image imagem = pictureBox13.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string nome = "Nome :  Mousse";
            string categoria = "Categoria : Comidas";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox19.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string nome = "Nome :  Arroz Com Feijão";
            string categoria = "Categoria : Comidas";
            string preco = "Preço : 3000 KZ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox14.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string nome = "Nome :  Mousse";
            string categoria = "Categoria : Comidas ";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox15.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Bife Molhado ";
            string categoria = "Categoria : Cozidos";
            string preco = "Preço : 3500 KZ";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p,s);
            Image imagem = pictureBox17.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Mufete  ";
            string categoria = "Categoria : Comidas ";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox20.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            this.Hide();
            v.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Coca Cola ";
            string categoria = "Categoria : Refrigerantes";
            string preco = "Preço : 3500 KZ";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox21.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Fanta ";
            string categoria = "Categoria : Enlatados";
            string preco = "Preço : 3000 KZ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox6.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Sprite ";
            string categoria = "Categoria : Enlatados";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox5.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Fonte Viva";
            string categoria = "Categoria :Água Mineral ";
            string preco = "Preço : 2000 KZ";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox4.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Hidrate";
            string categoria = "Categoria : Água Mineral";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox27.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            string nome = "Nome : 7Up";
            string categoria = "Categoria : Gasosas";
            string preco = "Preço : 3500 KZ";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox26.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Água Vitalis ";
            string categoria = "Categoria : Água Mineral ";
            string preco = "Preço : 3000 KZ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox25.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Luso ";
            string categoria = "Categoria : Água Mineral";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox24.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Maracujá ";
            string categoria = "Categoria : Sumos";
            string preco = "Preço : 2000 KZ";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox23.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Acerola ";
            string categoria = "Categoria :Sumos ";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox32.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Coco ";
            string categoria = "Categoria : Refrigerantes ";
            string preco = "Preço : 3500 KZ";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox31.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Coca Cola ";
            string categoria = "Categoria : Enlatados ";
            string preco = "Preço : 3000 KZ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox30.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Blue Laranja ";
            string categoria = "Categoria :Enlatados ";
            string preco = "Preço : 2500 KZ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox29.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            string nome = "Nome : Blue Polpa ";
            string categoria = "Categoria : Enlatados";
            string preco = "Preço : 2000 KZ";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox28.Image;
            Venda v = new Venda(imagem,nome,categoria,preco);
            v.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Estoque.Show();
        }
    }
}
