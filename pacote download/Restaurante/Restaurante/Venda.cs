using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Restaurante
{
    public partial class Venda : Form
    {
        private Image imagemRecebida;
        public Venda(Image imagem, string nome, string categoria, string preco)
        {
            InitializeComponent();
            imagemRecebida = imagem;
            txtNome.Text = nome;
            txtCategoria.Text = categoria;
            txtPreco.Text = preco;
        }
        
        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Vender v = new Vender(imagemRecebida);
            this.Hide();
            v.ShowDialog();
        }

        private void Venda_Load(object sender, EventArgs e)
        {

            FotoPrato.Image = imagemRecebida;
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           dbClasse c = new dbClasse();
           
        }
    }
}
