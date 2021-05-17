using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDTI
{
    /// <summary>
    /// A calculadora é responsavel por todas as funções matemáticas do programa
    /// </summary>
    public static class Calculadora
    {
        /// <summary>
        /// A função responsável pelo Calculo do HP do pokemon
        /// </summary>
        /// <param name="Bs">É o valor base do atributo, variável para cada pokemon</param>
        /// <param name="Iv">É o valor individual do pokémon, equivalente ao seu genero</param>
        /// <param name="Ev">É o valor dos esforços do pokemon</param>
        /// <param name="Lv">É o level do pokemon<</param>
        /// <returns></returns>
        public static int CalcularHp(int Bs, int Iv, int Ev, int Lv)
        {
            double hp = ((Iv + Bs + Math.Sqrt(Ev) / 8 + 50) * Lv) / 50 + 10;
            return (int)hp;
        }

        /// <summary>
        /// A função responsável pelo Calculo dos atributos gerais do pokemon
        /// </summary>
        /// <param name="Bs">É o valor base do atributo, variável para cada pokemon</param>
        /// <param name="Iv">É o valor individual do pokémon, equivalente ao seu genero</param>
        /// <param name="Ev">É o valor dos esforços do pokemon</param>
        /// <param name="Lv">É o level do pokemon<</param>
        /// <returns>O retorno é sempre o valor final e calculado dos atributos AT DF e SP</returns>
        public static int CalcularAtributo(int Bs, int Iv, int Ev, int Lv)
        {
            double atributo = ((Iv + Bs + Math.Sqrt(Ev) / 8) * Lv) / 50 + 5;
            return (int)atributo;
        }

        /// <summary>
        /// A função responsável por calcular o dano sofrido por um pokemon em uma rodada
        /// </summary>
        /// <param name="Ataque">É o atributo de atk do pokemon</param>
        /// <param name="Defesa">É o atributo de def do pokemon</param>
        /// <returns> O retorno é o dano causado a um pokemon, o mínimo é 1 </returns>
        public static int CalculoDano(int Ataque, int Defesa)
        {
            int Dano = Ataque - Defesa;
            if (Dano <= 0)
                Dano = 1;
            return Dano;
        }
    }
}
