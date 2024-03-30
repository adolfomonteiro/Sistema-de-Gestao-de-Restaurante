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
        private int totaldeEntrada = 0;
        private int totaldeSaida = 0;
        public Vender(Image image)
        {
            InitializeComponent();
        }
       
       public void ShowPanel(string panelName)
        {
            painel_Comidas.Visible = panelName == "Comida";
            panel_Bebidas.Visible = panelName == "Bebida";
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home h = new Home("");
            this.Hide();
            h.Show();
        }
        public void AdicionarPrecoVendido(int precoVendido, int saidaVendida)
        {
            totaldeEntrada += precoVendido;
            totaldeSaida += saidaVendida;
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nome = "Mousse ";
            string categoria = "Comidas";

            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image image = pictureBox1.Image;
            Venda v = new Venda(image,nome,categoria,p);
            v.ShowDialog();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
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
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            string nome = "Água Evian ";
            string categoria = "Água Mineral";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox22.Image;
            Venda ve = new Venda(imagem,nome,categoria,p);
            ve.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string nome = "Carne no Espeto ";
            string categoria = "Comidas";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox16.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nome = " Arroz Com Carne ";
            string categoria = "Comidas";
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox2.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string nome = "Arroz Com Feijão ";
            string categoria = "Comidas ";
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox3.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string nome = "Mufete";
            string categoria = "Cozido ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox9.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string nome = "Carne no espeto ";
            string categoria = "Cozidos ";
           
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox18.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string nome = "Bife Molhado ";
            string categoria = "Cozidos ";
            
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox10.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string nome = "Mufete ";
            string categoria = " Cozidos";
           
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox11.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string nome = "Arroz com Feijão ";
            string categoria = "Comidas";
            
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox12.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string nome = "Carne no Espeto ";
            string categoria = "Cozidos ";
           
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p,s);
            Image imagem = pictureBox13.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string nome = "Mousse";
            string categoria = " Comidas";
           
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox19.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string nome = " Arroz Com Feijão";
            string categoria = " Comidas";
            
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox14.Image;
            Venda v = new Venda(imagem, nome, categoria, p);
            v.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string nome = " Mousse";
            string categoria = " Comidas ";
            
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox15.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string nome = " Bife Molhado ";
            string categoria = " Cozidos";
        
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p,s);
            Image imagem = pictureBox17.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string nome = "Mufete  ";
            string categoria = " Comidas ";
            
            int p = 2500;
            int s = 1;
           AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox20.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string nome = " Coca Cola ";
            string categoria = " Refrigerantes";
           
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox21.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string nome = " Fanta ";
            string categoria = "Enlatados";
           
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox6.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string nome = " Sprite ";
            string categoria = " Enlatados";
            
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox5.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string nome = "Fonte Viva";
            string categoria = "Água Mineral ";
            
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox4.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            string nome = "Hidrate";
            string categoria = "Água Mineral";
            
            int p = 2500;
            int s = 1;
           AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox27.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            string nome = "7Up";
            string categoria = " Gasosas";
            
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox26.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            string nome = " Água Vitalis ";
            string categoria = " Água Mineral ";
            
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox25.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            string nome = "Luso ";
            string categoria = " Água Mineral";
           
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox24.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string nome = " Maracujá ";
            string categoria = " Sumos";
            
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox23.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            string nome = "Acerola ";
            string categoria = "Sumos ";
           
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox32.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            string nome = "Coco ";
            string categoria = "Refrigerantes ";
           
            int p = 3500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox31.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            string nome = "Coca Cola ";
            string categoria = "Enlatados ";
           
            int p = 3000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox30.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            string nome = "Blue Laranja ";
            string categoria = "Enlatados ";
            int p = 2500;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox29.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            string nome = " Blue Polpa ";
            string categoria = " Enlatados";
            int p = 2000;
            int s = 1;
            AdicionarPrecoVendido(p, s);
            Image imagem = pictureBox28.Image;
            Venda v = new Venda(imagem,nome,categoria,p);
            v.ShowDialog();
        }
        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            FormEstoque f = new FormEstoque();
            f.ShowDialog();
        }
    }
}
