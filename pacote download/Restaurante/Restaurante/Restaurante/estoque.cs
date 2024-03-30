using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class estoque : cl_geral
    {
        protected override string nomeDoProduto
        {
            get
            {
                return base.nomeDoProduto;
            }

            set
            {
                base.nomeDoProduto = value;
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
        protected override int preco
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
    }
}
