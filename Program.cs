using System.Security.Cryptography;

namespace Exercicio014
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //Variáveis
            int qtd = 0, valores = 0;

            Console.Write("Informe a quantidade de valores que você deseja realizar a operação: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out qtd))
            {
                valores = Convert.ToInt32(Soma(qtd));
            }
            else
            {
                Console.WriteLine("Entrada de dados inválida!");
            }
        }

        public static double Soma(int quantidade)
        {
            //Variáveis
            double[] soma;
            double resultado;

            soma = new double[quantidade];

            for (int i = 0; i < soma.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                soma[i] = Convert.ToDouble(Console.ReadLine());
            }

            resultado = soma.Sum();

            Console.WriteLine($"Resultado da operação: {Math.Round(resultado, 2)}");

            return resultado;
        }
    }
}