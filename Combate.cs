using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDTI
{

    /// <summary>
    /// Classe contendo as regras de negócio da batalha
    /// </summary>
    public static class Combate
    {
        /// <summary>
        /// A função luta é responsável pela lógica do combate
        /// </summary>
        /// <param name="Primeiro">Primeiro pokemon da batalha</param>
        /// <param name="Segundo">Segundo pokemon da batalha</param>
        /// <returns>Resutado da batalha</returns>
        public static string Luta(PokemonModel Primeiro, PokemonModel Segundo)
        {
            int VidaAtualPrimeiro = Primeiro.hp;
            int VidaAtualSegundo = Segundo.hp;
            int Turnos = 1;

            /// Aqui calcula-se a quantidade de turnos necessária para o fim do combate
            while (VidaAtualPrimeiro > 0 && VidaAtualSegundo > 0)
            {
                VidaAtualPrimeiro -= Calculadora.CalculoDano(Segundo.atk, Primeiro.def);
                VidaAtualSegundo -= Calculadora.CalculoDano(Primeiro.atk, Segundo.def);
                Turnos++;
            }

            /// Aqui calcula-se o embate de velocidade, caso ambos os pokemons fiquem com zero ou menos de vida no mesmo turno
            if (VidaAtualPrimeiro <= 0 && VidaAtualSegundo <= 0)
            {
                if (Primeiro.sp > Segundo.sp)
                    return MensagemVencedor(Primeiro.nome, Turnos);
                else if (Primeiro.sp < Segundo.sp)
                    return MensagemVencedor(Segundo.nome, Turnos);
                else
                    return "Ocorreu um empate em " + Turnos;
            }

            if (VidaAtualPrimeiro > VidaAtualSegundo)
                return MensagemVencedor(Primeiro.nome, Turnos);
            else 
                return MensagemVencedor(Segundo.nome, Turnos);
        }  

        /// <summary>
        ///  A função MensagemVencedor é responsável por imprimir na tela uma mensagem indicando o pokemon que venceu e a quantidade de turnos
        /// </summary>
        /// <param name="NomePokemon"> O nome do pokemon vencedor, impresso na mensagem de vitória</param>
        /// <param name="Turnos"> A quantidade de turnos do combate, impressa na mensagem de vitória</param>
        /// <returns></returns>
        private static string MensagemVencedor(string NomePokemon, int Turnos)
        {
            return NomePokemon + " venceu em " + Turnos + " Turnos";
        }
    }
}
