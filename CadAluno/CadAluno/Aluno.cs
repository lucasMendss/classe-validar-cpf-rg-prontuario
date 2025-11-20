using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CadAluno
{
    internal class Aluno
    {
        private string _prontuario;
        private string _nome;
        private string _cpf;
        private string _rg;
        private string _email;

        public string prontuario
        {
            get { return _prontuario; }
            set
            {
                if (!Validacoes.ValidarProntuario(value)) { throw new Exception("Prontuário Inválido."); }
                else { _prontuario = value; }
            }
        }
        public string nome
        {
            get { return _nome; }
            set
            {
                if (!Validacoes.ValidarNome(value)) { throw new Exception("Nome inválido."); }
                else { _nome = value; }
            }
        }
        public string cpf
        {
            get { return _cpf; }
            set
            {
                if (!Validacoes.ValidarCPF(value)) { throw new Exception("CPF inválido."); }
                else { _cpf = value; }
            }
        }
        public string rg 
        {
            get { return _rg; }
            set
            {
                if (!Validacoes.ValidarRGDeSP(value)) { throw new Exception("RG inválido."); }
                else { _rg = value; }
            }
        }
        public string email
        {
            get { return _email; }
            set
            {
                if (!Validacoes.ValidarEmail(value)) { throw new Exception("E-mail inválido."); }
                else { _email = value; }
            }
        }
        public bool consultarAluno()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=dbAcademico;Integrated Security=True;";
            SqlCommand comando = new SqlCommand();
            comando.Connection = conn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select prontuario, nome, cpf, rg, email from alunos where prontuario = @prontuario";
            comando.Parameters.AddWithValue("@prontuario", this.prontuario);

            conn.Open();
            SqlDataReader dataReader = comando.ExecuteReader();
            if(!dataReader.Read())
            {
                return false;
            }
            this.nome = dataReader["nome"].ToString();
            this.cpf = dataReader["cpf"].ToString();
            this.rg = dataReader["rg"].ToString();
            this.email = dataReader["email"].ToString();
            conn.Close();
            return true;
        }
        public void cadastrarAluno()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=localhost;Initial Catalog=dbAcademico;Integrated Security=True;";
                SqlCommand comando = new SqlCommand();
                comando.Connection = conn;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "insert into alunos (prontuario, nome, cpf, rg, email) values (@prontuario, @nome, @cpf, @rg, @email)";
                comando.Parameters.AddWithValue("@prontuario", this.prontuario);
                comando.Parameters.AddWithValue("@nome", this.nome);
                comando.Parameters.AddWithValue("@cpf", this.cpf);
                comando.Parameters.AddWithValue("@rg", this.rg);
                comando.Parameters.AddWithValue("@email", this.email);

                conn.Open();
                comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao se conectar com o banco de dados.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
