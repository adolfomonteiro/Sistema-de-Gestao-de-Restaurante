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
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Pagina_Inicial.Show();
            Conta_Gestor.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Pagina_Inicial.Show();
            Conta_Gestor.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta_Gestor.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
