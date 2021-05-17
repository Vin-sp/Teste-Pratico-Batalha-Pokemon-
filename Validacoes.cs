using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDTI
{
    /// <summary>
    /// Todas as funções na classe de Validacoes possuem metodos para checar se os números colocados pelo usuário estão corretos
    /// </summary>
    public static class Validacoes
    {
        /// <summary>
        /// Função responsável por validar o nivel
        /// </summary>
        /// <param name="escrita"> O nível escrito inicialmente pelo usuário, podendo ou não ser correto</param>
        /// <returns> Um valor válido para o nível</returns>
        public static int ValidaLvL (string escrita)
        {
            int numero;
            int.TryParse(escrita, out numero); 
            while (numero < 1 || numero > 99)
            {
                Console.WriteLine("O nivel foi invalido. Escreva um nivel valido de pokemon:");
                int.TryParse(Console.ReadLine(), out numero);
            }

            return numero;
       
        }

        /// <summary>
        /// Função responsável por validar o Bs
        /// </summary>
        /// <param name="escrita"> O Bs escrito inicialmente pelo usuário, podendo ou não ser correto</param>
        /// <returns> Um valor válido para o Bs</returns>
        public static int ValidaBs(string escrita)
        {
            int numero;
            int.TryParse(escrita, out numero);
            while (numero < 1 || numero > 255)
            {
                Console.WriteLine("O Bs foi invalido. Escreva um valor de Bs valido para o pokemon");
                int.TryParse(Console.ReadLine(), out numero);
            }

            return numero;

        }

        /// <summary>
        /// Função responsável por validar o Iv
        /// </summary>
        /// <param name="escrita"> O Iv escrito inicialmente pelo usuário, podendo ou não ser correto</param>
        /// <returns> Um valor válido para o Iv</returns>
        public static int ValidaIv(string escrita)
        {
            int numero;
            int.TryParse(escrita, out numero);
            while (numero < 1 || numero > 15)
            {
                Console.WriteLine("O Iv foi invalido. Escreva um valor de Iv valido para o pokemon");
                int.TryParse(Console.ReadLine(), out numero);
            }

            return numero;

        }

        /// <summary>
        /// Função responsável por validar o Ev
        /// </summary>
        /// <param name="escrita"> O Ev escrito inicialmente pelo usuário, podendo ou não ser correto</param>
        /// <returns> Um valor válido para o Ev</returns>
        public static int ValidaEv(string escrita)
        {
            int numero;
            int.TryParse(escrita, out numero);
            while (numero < 1 || numero > 262140)
            {
                Console.WriteLine("O Ev foi invalido. Escreva um valor de Ev valido para o pokemon");
                int.TryParse(Console.ReadLine(), out numero);
            }

            return numero;

        }
    }
}
