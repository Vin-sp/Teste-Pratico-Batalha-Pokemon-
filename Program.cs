using System;

namespace TesteDTI
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonModel[] Pokedex = new PokemonModel[2];

            Console.WriteLine("Iniciando o programa, insira os valores");

            ObterValores(Pokedex);

            RealizarBatalha(Pokedex);
        }

        /// <summary>
        /// A função obtém os valores necessários para o preenchimento de um objeto da classe PokemonModel
        /// </summary>
        /// <param name="Pokedex"> É o nome dado para o array de objetos da classe PokemonModel</param>
        private static void ObterValores(PokemonModel[] Pokedex)
        {
            for (int i = 0; i < Pokedex.Length; i++)
            {
                Pokedex[i] = new PokemonModel();

                string[] linhaNomeNivel = Console.ReadLine().Split(' ');
                Pokedex[i].nome = linhaNomeNivel[0];
                Pokedex[i].nivel = Validacoes.ValidaLvL(linhaNomeNivel[1]);

                /// Uma vez definido e checado o nome do pokemon é hora de definir seus atributos
                /// O loop a seguir analisa linha por linha os valores colocados para o BS IV e EV do pokemon, utilizando as funções da validação para isso             
                for (int p = 0; p < 4; p++)
                {
                    string[] linhaAtributo = Console.ReadLine().Split(' ');
                    int BS = Validacoes.ValidaBs(linhaAtributo[0]);
                    int IV = Validacoes.ValidaIv(linhaAtributo[1]);
                    int EV = Validacoes.ValidaEv(linhaAtributo[2]);

                    /// Switch para a atribuição dos valores no objeto da classe pokemon
                    switch (p)
                    {
                        case 0:
                            Pokedex[i].hp = Calculadora.CalcularHp(BS, IV, EV, Pokedex[i].nivel);
                            break;
                        case 1:
                            Pokedex[i].atk = Calculadora.CalcularAtributo(BS, IV, EV, Pokedex[i].nivel);
                            break;
                        case 2:
                            Pokedex[i].def = Calculadora.CalcularAtributo(BS, IV, EV, Pokedex[i].nivel);
                            break;
                        case 3:
                            Pokedex[i].sp = Calculadora.CalcularAtributo(BS, IV, EV, Pokedex[i].nivel);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Com o inicio do combate, é necessario que o usuário saiba quais pokemons estão lutando e os seus respectivos atributos calculados
        /// O resultado da batalha é dado ao mesmo tempo 
        /// </summary>
        /// <param name="Pokedex">É o nome dado para o array de objetos da classe PokemonModel</param>
        private static void RealizarBatalha(PokemonModel[] Pokedex)
        {
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hora da Batalha!");
            Console.WriteLine(Pokedex[0].nome + " versus " + Pokedex[1].nome);

            for (int n = 0; n < 2; n++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Pokemon:" + Pokedex[n].nome + " " + Pokedex[n].nivel);
                Console.WriteLine("HP: " + Pokedex[n].hp);
                Console.WriteLine("AT: " + Pokedex[n].atk);
                Console.WriteLine("DF: " + Pokedex[n].def);
                Console.WriteLine("SP: " + Pokedex[n].sp);
            }

            Console.WriteLine(Combate.Luta(Pokedex[0], Pokedex[1]));
            Console.ReadKey();
        }
    }
}
