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
    public partial class Cadastrar_Funcionarios : Form
    {
        public Cadastrar_Funcionarios()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "" && txtTelefone.Text=="" && txtEmail.Text=="" && txtMorada.Text=="" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha Tudo!");
            }
            else
            {
                base_dados b = new base_dados();
                b.CadastrarFuncionarios(txtNome.Text, txtEmail.Text, int.Parse(txtTelefone.Text), txtMorada.Text, txtSenha.Text);
                txtEmail.Text = "";
                txtMorada.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
                txtTelefone.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            login_funcionario l = new login_funcionario();
            this.Hide();
            l.ShowDialog();
        }

        private void ocultado_Click(object sender, EventArgs e)
        {
            mostrado.Show();
            ocultado.Visible = false;
            if(txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.PasswordChar = txtSenha.PasswordChar;
            }
            else
            {
                txtSenha.PasswordChar = '\0';
            }
           
        }

        private void mostrado_Click(object sender, EventArgs e)
        {
            ocultado.Show();
            mostrado.Visible = false;
        }
    }
}
