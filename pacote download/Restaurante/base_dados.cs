using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    class base_dados : cl_geral
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
        protected override string senha
        {
            get
            {
                return base.senha;
            }

            set
            {
                base.senha = value;
            }
        }
        protected override string NomeFunc
        {get{return base.NomeFunc;}set{base.NomeFunc = value;}}
        protected override string email
        {
            get
            {
                return base.email;
            }
            set
            {
                base.email = value;
            }
        }
        protected override int telefone
        {
            get
            {
                return base.telefone;
            }
            set
            {
                base.telefone = value;
            }
        }
        protected override string morada
        {
            get
            {
                return base.morada;
            }
            set
            {
                base.morada = value;
            }
        }

        protected override string palavraPasse
        {
            get
            {
                return base.palavraPasse;
            }
            set
            {
                base.palavraPasse = value;
            }
        }
        protected override int id
        {
            get
            {
                return base.id;
            }
            set
            {
                base.id = value;
            }
        }
        protected override MySqlConnection connection()
        {
            return base.connection();
        }
        public void SenhaDoGestor(string _senha)
        {
            this.senha = _senha;

            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = "select from gestor  where senha=@senha";
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                conexao.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        public void CadastrarGestor(string _nome, string _email, int _telefone, string _senha)
        {
            this.NomeFunc = _nome;
            this.email = _email;
            this.telefone = _telefone;
            this.palavraPasse = _senha;

            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO gestor VALUES(default,@nome,@telefone,@email,@senha)";
                comando.Parameters.AddWithValue("@nome", NomeFunc);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@senha", palavraPasse);
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                conexao.Dispose();

                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        public void CadastrarFuncionarios(string _nome, string _email, int _telefone, string _morada, string _senha)
        {
            this.NomeFunc = _nome;
            this.email = _email;
            this.telefone = _telefone;
            this.morada = _morada;
            this.palavraPasse = _senha;

            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO cad_funcionarios VALUES(default,@nome,@telefone,@email,@morada,@senha)";
                comando.Parameters.AddWithValue("@nome", NomeFunc);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@morada", morada);
                comando.Parameters.AddWithValue("@senha", palavraPasse);
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                conexao.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        public void AdicionarProduto(string _nomeDoProuto, string _categoria, string _subcategoria, int _preco, int _quantidade)
        {
            this.nomeDoProduto = _nomeDoProuto;
            this.categoria = _categoria;
            this.subcategoria = _subcategoria;
            this.preco = _preco;
            this.quantidade = _quantidade;

            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO Produtos VALUES(@nome,@categoria,@preco,@quantidade)";
                comando.Parameters.AddWithValue("@nome", nomeDoProduto);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@preco", preco);
                comando.Parameters.AddWithValue("@quantidade", quantidade);

                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                conexao.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        public void PesquisarProduto(string _nome)
        {
            this.nomeDoProduto = _nome;

            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = $"SELECT * FROM Produtos WHERE nome like '%@nome%'";
                comando.Parameters.AddWithValue("@nome", nomeDoProduto);

                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }

        }
        public void EditarProduto(int _id, string _nome, string _categoria, int _preco, int _quantidade)
        {
            this.id = _id;
            this.nomeDoProduto = _nome;
            this.categoria = _categoria;
            this.preco = _preco;
            this.quantidade = _quantidade;

            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = $"UPDATE Produtos SET nome=@nome, categoria=@categoria,preco=@preco,quantidade=@quantidade WHERE id = @id";
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nome", nomeDoProduto);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@preco", preco);
                comando.Parameters.AddWithValue("@quantidade", quantidade);

                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
        public void EliminarProduto(int _id)
        {
            this.id = _id;
            MySqlConnection conexao = connection();
            MySqlCommand comando = new MySqlCommand();

            try
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM Produtos Where id = @id";
                comando.Parameters.AddWithValue("@id", id);

                comando.Connection = conexao;
                comando.ExecuteNonQuery();
                comando.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
