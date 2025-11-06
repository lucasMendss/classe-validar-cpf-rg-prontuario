using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }
        }
        public string cpf
        {
            get { return _cpf; }
            set
            {
                if (!Validacoes.ValidarCPF(value)) { throw new Exception("CPF inválido."); }
            }
        }
    }
}
