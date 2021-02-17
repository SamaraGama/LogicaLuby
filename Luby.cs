using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaLuby
{
    class Luby
    {
        public string CalcularFatorial(int num)
        {
            int fatorialDeNum = num;
            for (int antecessor = 1; antecessor < num; antecessor++)
            {
                fatorialDeNum *= antecessor;
            }
            return $"O fatorial de {num} é {fatorialDeNum} ({num}! = {fatorialDeNum}).";
        }

        public string CalcularPremio(double premio, string tipo, double fatorProprio = 0)
        {
            if (premio == 0)
            {
                return "Prêmios devem ser maiores do que zero!";
            }
            if (fatorProprio != 0)
            {
                premio *= fatorProprio;
                return $"O valor do prêmio é {premio}.";
            }
            if (tipo == "basic")
            {
                return $"O valor do prêmio é {premio}.";
            }
            if (tipo == "vip")
            {
                premio *= 1.2;
                return $"O valor do prêmio é {premio}.";
            }
            if (tipo == "premium")
            {
                premio *= 1.5;
                return $"O valor do prêmio é {premio}.";
            }
            if (tipo == "deluxe")
            {
                premio *= 1.8;
                return $"O valor do prêmio é {premio}.";
            }
            if (tipo == "special")
            {
                premio *= 2;
                return $"O valor do prêmio é {premio}.";
            }
            return null;

        }

        //public string ContarNumerosPrimos(int num)
        //{
        //    return $"Existem {totalNumerosPrimos} números primos que antecedem o número {num}";
        //}
        public string CalcularVogais(string str)
        {
            int totalVogais = 0;
            int len = str.Length;

            for (var i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    totalVogais++;
                }
            }
            return $"Existem {totalVogais} vogais nessa string.";
        }

        public string CalcularValorComDescontoFormatado(string valor, string desconto)
        {
            //tratamento do valor
            valor.Replace(".", "");
            valor.Replace(",", ".");
            string valor2 = valor.Remove(0, 3);
            float valor3 = float.Parse(valor2);
            
            //tratamento do valor de desconto
            string desconto2 = desconto.Remove(desconto.Length -1, 1);
            int desconto3 = int.Parse(desconto2);

            float novoValor = valor3 - (valor3/100 * desconto3);

            return $"O novo valor com desconto aplicado é: R$ {novoValor}.";
        }

        public void ObterElementosPares(int[] vetor)
        {
            var vetorlista = new List<int>();
           
            foreach (int num in vetor)
            {
                if (num % 2 == 0)
                {
                    vetorlista.Add(num);
                }
            }
            Console.Write("Lista de números pares:");
            foreach (int num in vetorlista)
            {
                Console.Write($" {num},");
            }
        }

        

    }
}
