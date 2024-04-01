using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    class dbClasse : cl_vender
    {
        protected override string nome
        {
            get
            {
                return base.nome;
            }

            set
            {
                base.nome = value;
            }
        }
        protected override string categoria
        {
            get
            {
                return base.categoria;
            }

            set
            {
                base.categoria = value;
            }
        }
        protected override string preco
        {
            get
            {
                return base.preco;
            }

            set
            {
                base.preco = value;
            }
        }
        protected override MySqlConnection connection()
        {
            return base.connection(); 
        }
        
    }
}
