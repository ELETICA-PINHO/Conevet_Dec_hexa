using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Autor: ALESSANDRO PINHO
 * DATA : 23-05-2019
 * PROJETO : FACULDADE
 * DESCRIÇÃO
 *
 * CONVERTE NUMEROS DE 0 HÁ 300
 * CASO HAJA NECESSEIDA PODE SER AUTERADO PRIMEIRO IF
 * PARA ACEITAR VALOR DE 0 HA 4095
 * ESSE PROGRMA SÓ CONVERTE HEXA D 3 DIGITOS OU SEJA
 * EX  DEC 4095 HEXA FF
 * DEX 4097 ERRO 1000
 *

 *
 */

namespace Converte_Decimal_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {

            //vetor de hexa 0 a 15
            char[] vetor_Hexa = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            //variaveis de processamento
            char convertQ = ' ';
            char convertR = ' ';
            string convert = " ";

            int convert_quociente = 0;
            int convert_resto = 0;

            int N_digitado = 0;
            int base_divisor = 16;
            char resto1 = ' ';
            int quociente1 = 0;


            Console.WriteLine("Digite um numero entre 0 e 300 !! ");
            N_digitado = Convert.ToInt32(Console.ReadLine());

            if (N_digitado <= 0 || N_digitado <= 300)  // condição numero
            {
                convert_quociente = N_digitado / base_divisor;
                convert_resto = N_digitado % base_divisor;

                if (N_digitado <= 256) // ATE 256 DECIMAIS
                {
                    convertQ = vetor_Hexa[convert_quociente];   //VETOR CONVERSÃO
                    convertR = vetor_Hexa[convert_resto];       //VETOR CONVERSÃO
                    convert = Convert.ToString(convertQ) + Convert.ToString(convertR);  //MONTAGEM HEXA AT 256
                }



                if (N_digitado > 256)
                {
                    quociente1 = convert_quociente;
                    resto1 = vetor_Hexa[convert_resto];  //menos sequinativo 3

                    if (convert_quociente >= 16)
                    {
                        convertQ = vetor_Hexa[quociente1 / base_divisor];  ////menos sequinativo 1
                        convertR = vetor_Hexa[quociente1 % base_divisor];  ////menos sequinativo 2




                    }

                    convert = Convert.ToString(convertQ) + Convert.ToString(convertR) + Convert.ToString(resto1);
                    //                                1                            2                             3

                }


                //  Console.WriteLine("Quociente = " + convert_quociente);
                //    Console.WriteLine("Resto = "     + convert_resto);
                /////   Console.WriteLine("Quociente com = " + convertQ);
                ///   Console.WriteLine("Resto com = " + convertR);
                Console.WriteLine("HEXA-DECIMAL >>> " + convert);
                Console.ReadLine();

            } // if 0 300
            else
            {
                Console.WriteLine("Valor não é permitido tente novamente, 0 a 300");
                Console.ReadLine();
            }  // else 0 300

        }
    }
}
