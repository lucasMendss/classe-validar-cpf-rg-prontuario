using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAluno
{
    public static class Validacoes
    {
        public static bool ValidarCPF(string cpf)
        {
            string CPFLimpo = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            if (CPFLimpo.Length != 11)
            {
                return false;
            }

            char[] CPFAsCharArray = CPFLimpo.ToCharArray();
            HashSet<char> digitosNaoRepetidosCPF = new HashSet<char>(CPFAsCharArray);

            if (digitosNaoRepetidosCPF.Count == 1)
            {
                return false;
            }

            int soma = 0;
            int multiplicador = 10;
            for (int i = 0; i < CPFLimpo.Length - 2; i++)
            {
                soma += int.Parse(CPFLimpo[i].ToString()) * multiplicador;
                multiplicador--;
            }

            int digito10 = CPFLimpo[9] - '0';
            int resto = soma % 11;
            if (resto == 0 || resto == 1)
            {
                if (digito10 != 0) { return false; }
            }
            else
            {
                if (digito10 != 11 - resto) { return false; }
            }

            soma = 0;
            multiplicador = 11;
            for (int i = 0; i < CPFLimpo.Length - 1; i++)
            {
                soma += int.Parse(CPFLimpo[i].ToString()) * multiplicador;
                multiplicador--;
            }
            int digito11 = CPFLimpo[10] - '0';
            resto = soma % 11;
            if (digito11 != 11 - resto) { return false; }

            return true;
        }

        public static bool ValidarRGDeSP(string rg)
        {
            string RGLimpo = rg.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");

            if (RGLimpo.Length != 9) { return false; }

            char[] RGAsCharArray = RGLimpo.ToCharArray();
            HashSet<char> digitosRG = new HashSet<char>(RGAsCharArray);
            if (digitosRG.Count == 1)
            {
                return false;
            }
            
            int soma = 0;
            int multiplicador = 2;
            for (int i = 0; i < RGLimpo.Length - 1; i++)
            {
                soma += int.Parse(RGLimpo[i].ToString()) * multiplicador;
                multiplicador++;
            }

            int resto = soma % 11;
            string ultimoDigito = RGLimpo[8].ToString();

            if(resto == 10)
            {
                if (ultimoDigito != "X") return false;
            }
            else if(resto == 0)
            {
                if(ultimoDigito != "0") return false;
            }
            else
            {
                if(ultimoDigito != (11 - resto).ToString()) return false;
            }

            return true;
        }

        public static bool ValidarProntuario(string prontuario)
        {
            string prontuarioLimpo = prontuario.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");

            if (prontuarioLimpo.Length != 9) { return false; }

            if (prontuarioLimpo[0] != 'C' || prontuarioLimpo[1] != 'B') { return false; }

            int soma = 0;
            int multiplicador = 7;
            int index = 2;
            while(index <= 7)
            {
                soma += int.Parse(prontuarioLimpo[index].ToString()) * multiplicador;
                multiplicador--;
                index++;
            }

            int resto = soma % 11;
            int digitoVerificador = 11 - resto;
            char ultimoDigito = prontuarioLimpo[8];

            if(digitoVerificador == 10)
            {
                if(ultimoDigito != 'X') { return false;}
            }
            else
            {
                if (ultimoDigito != '1') { return false; }
            }
    
            return true;   
        }

        public static bool ValidarNome(string nome)
        {
            nome = nome.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            if (nome.Length == 0) { return false; }

            return true;
        }
    }
}
