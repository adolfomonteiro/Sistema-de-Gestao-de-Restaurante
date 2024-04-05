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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value <= 99 )
            {
                timer1.Start();
                for (int i = 0; i <= 10000000; i++) ;
                guna2ProgressBar1.Value += 3;
            }
            else
            {
                timer1.Stop();
                login_funcionario formulario = new login_funcionario();
                this.Hide();
                formulario.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            }
    }
}
