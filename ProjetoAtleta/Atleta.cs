using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura, peso;
        private DateTime dataNascimento;

        public string Nome
        {
            set
            {
                if (value != string.Empty) nome = value;
                else throw new Exception("o nome é obrigatório!");
            }
            get
               {
                   return Nome;
               }
            
        }

        public double Altura
        {
            set
            {
                if (value >= 1) altura = value;
                else throw new Exception("A altura mínima é de 1 metro!");
            }
            get
            {
                return altura;
            }

        }

        public double Peso
        {
            set
            {
                if (value >= 40) peso = value;
                else throw new Exception("O peso mínimo é 40kg!");
            }
            get
            {
                return peso;
            }

        }

        public DateTime DataNasimento
        {
            set { dataNascimento = value; }
            get { return dataNascimento; }
        }

        public string calcularIdade()
        {
            TimeSpan diferenca = DateTime.Today.Subtract(dataNascimento);
            double idade = Math.Floor(diferenca.TotalDays / 365);
            return "A sua idade é: " + idade;
        }

        public string calcularIMC()
        {
            double resultado = peso / Math.Pow(altura, 2);
            return "seu IMC é: " + resultado;
        }
    }
}
