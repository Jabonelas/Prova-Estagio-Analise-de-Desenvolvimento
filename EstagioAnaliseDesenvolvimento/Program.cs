using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstagioAnaliseDesenvolvimento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ///////////////////////////  2ª Questão  /////////////////////////

            int A = 0;
            int B = 1;
            int C = 0;
            int numeroInformado = 0;

            Console.WriteLine("Informe o numero!");

            numeroInformado = Convert.ToInt32(Console.ReadLine());

            Console.Write("0.1.");

            for (int i = 0; i <= numeroInformado; i++)
            {
                C = A;

                A = B;

                B = A + C;

                if (B < numeroInformado)
                {
                    Console.Write($"{B}.");
                }
            }

            Console.ReadLine();

            ///////////////////////////  3ª Questão  /////////////////////////

            double valorTotal = 0;

            double[] mes = new double[30];

            mes[0] = 22174.1664;

            mes[1] = 24537.6698;

            mes[2] = 26139.6134;

            mes[3] = 0.0;

            mes[4] = 0.0;

            mes[5] = 26742.6612;

            mes[6] = 0.0;

            mes[7] = 42889.2258;

            mes[8] = 46251.174;

            mes[9] = 11191.4722;

            mes[10] = 0.0;

            mes[11] = 0.0;

            mes[12] = 3847.4823;

            mes[13] = 373.7838;

            mes[14] = 2659.7563;

            mes[15] = 48924.2448;

            mes[16] = 18419.2614;

            mes[17] = 0.0;

            mes[18] = 0.0;

            mes[19] = 35240.1826;

            mes[20] = 43829.1667;

            mes[21] = 18235.6852;

            mes[22] = 4355.0662;

            mes[23] = 13327.1025;

            mes[24] = 0.0;

            mes[25] = 0.0;

            mes[26] = 25681.8318;

            mes[27] = 1718.1221;

            mes[28] = 13220.495;

            mes[29] = 8414.61;

            double media = 0;

            double menorValor = 0;

            double maiorValor = 0;

            int contDias = 0;

            for (int i = 0; i < mes.Length; i++)
            {
                if (mes[i] != 0)
                {
                    valorTotal += mes[i];

                    if (mes[i] < menorValor && mes[i] != 0.0)
                    {
                        menorValor = mes[i];
                    }
                    if (mes[i] > maiorValor)
                    {
                        maiorValor = mes[i];
                    }
                }
            }

            media = valorTotal / mes.Length;

            for (int i = 0; i < mes.Length; i++)
            {
                if (mes[i] > media)
                {
                    contDias++;
                }
            }

            Console.WriteLine($"Menor valor {menorValor}");
            Console.WriteLine($"Maior valor {maiorValor}");
            Console.WriteLine($"Quantidade de dias que o faturamento foi maior que a media {contDias}");

            Console.ReadLine();

            ///////////////////////////  4ª Questão  /////////////////////////

            double SP = 67836.43;

            double RJ = 36678.66;

            double MG = 29229.88;

            double ES = 27165.48;

            double Outros = 19849.53;

            double somaTotal = SP + RJ + MG + ES + Outros;

            Console.WriteLine($"SP - {(SP * 100 / somaTotal).ToString("N2")}%");
            Console.WriteLine($"RJ - {(RJ * 100 / somaTotal).ToString("N2")}%");
            Console.WriteLine($"MG - {(MG * 100 / somaTotal).ToString("N2")}%");
            Console.WriteLine($"ES - {(ES * 100 / somaTotal).ToString("N2")}%");
            Console.WriteLine($"Outros - {(Outros * 100 / somaTotal).ToString("N2")}%");

            Console.ReadLine();

            ///////////////////////////  5ª Questão  /////////////////////////

            string palavra = "ISRAEL";

            Console.WriteLine(palavra);

            List<char> palavraquebrada = new List<char>();

            char[] stringQuebrada = palavra.ToCharArray();

            for (int i = 5; i >= 0; i--)
            {
                Console.Write(stringQuebrada[i]);
            }

            Console.ReadLine();
        }
    }
}