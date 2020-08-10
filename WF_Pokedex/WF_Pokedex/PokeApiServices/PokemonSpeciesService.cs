using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WF_Pokedex.PokeApiServices;

namespace WF_Pokedex
{
    public class PokemonSpeciesService : PokeApiService
    {
        public override string CategoryString => "pokemon-species";
    }
}
