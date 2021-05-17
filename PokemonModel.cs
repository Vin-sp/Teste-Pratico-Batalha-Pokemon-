using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDTI
{
    /// <summary>
    /// O modelo para todo o pokemon com Getters e Setters para todos os atributos individuais do objeto
    /// </summary>
    public class PokemonModel
    {
        public string nome { get; set; }
        public int nivel { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int sp { get; set; }

    }
}
