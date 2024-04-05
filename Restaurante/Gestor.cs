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
    public partial class Gestor : Form
    {
        public Gestor()
        {
            InitializeComponent();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if(txtNome.Text =="" && txtEmail.Text =="" && txtTelefone.Text=="" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha Tudo!");
            }
            else
            {
                base_dados db = new base_dados();
                db.CadastrarGestor(txtNome.Text, txtEmail.Text, int.Parse(txtTelefone.Text), txtSenha.Text);
                txtEmail.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
                txtTelefone.Text = "";
            }
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Home home = new Home("");
            this.Hide();
            home.Show();
        }
    }
}
