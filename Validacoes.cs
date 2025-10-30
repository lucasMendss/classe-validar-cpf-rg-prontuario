using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VerificaCPF
{
    public static class Validacoes
    {  
        public static string ValidarCPF(string cpf)
        {
            string CPFLimpo = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Trim();
            if(CPFLimpo.Length != 11)
            {
                return CPFLimpo + ": CPF inválido.";
            }

            char[] CPFAsCharArray = CPFLimpo.ToCharArray();
            HashSet<char> digitosNaoRepetidosCPF = new HashSet<char>(CPFAsCharArray);

            if(digitosNaoRepetidosCPF.Count == 1)
            {
                return CPFLimpo + ": CPF inválido.";
            }

            int soma = 0;
            int multiplicador = 10;
            for(int i = 0; i < CPFLimpo.Length - 2; i++)
            {
                soma += int.Parse(CPFLimpo[i].ToString()) * multiplicador;
                multiplicador--;
            }

            int digito10 = CPFLimpo[9] - '0';
            int resto = soma % 11;
            if (resto == 0 || resto == 1)
            {
                if (digito10 != 0) { return CPFLimpo + ": CPF inválido."; }
            }
            else
            {
                if (digito10 != 11 - resto) { return CPFLimpo + ": CPF inválido."; }
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
            if(digito11 != 11 - resto) { return CPFLimpo + ": CPF inválido."; }

            return CPFLimpo + ": CPF válido.";    
        }

        public static string ValidarRG(string rg)
        {
            string RGLimpo = rg.Replace(".", "").Replace("-", "").Replace("/", "").Trim();

            if(RGLimpo.Length != 9) { return rg + ": RG inválido."; }

            char[] RGAsCharArray = RGLimpo.ToCharArray();
            HashSet<char> digitosRG = new HashSet<char>(RGAsCharArray);
            if (digitosRG.Count == 1)
            {
                return rg + ": CPF inválido.";
            }

            int soma = 0;
            int multiplicador = 10;
            for (int i = 0; i < RGLimpo.Length - 1; i++)
            {
                soma += int.Parse(RGLimpo[i].ToString()) * multiplicador;
                multiplicador--;
            }
            char ultimoDigito = RGLimpo[8];
            if (ultimoDigito == 'X') { soma += 1000; }
            else {  soma += Convert.ToInt32(ultimoDigito) * 100; }

            if(soma % 10 != 0) { return rg + ": RG inválido."; }
            else { return rg + ": RG válido."; }
            
        }

    }
}
