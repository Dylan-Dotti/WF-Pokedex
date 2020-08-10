using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Pokedex
{
    public class Pokemon
    {
        public string Name { get; private set; }
        public string DisplayName { get => converter.GetDisplayName(Name); }

        public int Id { get; private set; }
        public string Genus { get; private set; }
        public string Type1 { get; private set; }
        public string Type2 { get; private set; }
        public float Height { get; private set; }
        public float Weight { get; private set; }
        public Image FrontSprite { get; private set; }
        public IReadOnlyDictionary<string, string> PokedexEntries { get; private set; }

        private readonly PokeApiNameConverter converter;

        public Pokemon(string name, int id, string genus,
            string type1, string type2, float height, float weight,
            Image frontSprite, IReadOnlyDictionary<string, string> pokedexEntries)
        {
            Name = name;
            Id = id;
            Genus = genus;
            Type1 = type1;
            Type2 = type2;
            Height = height;
            Weight = weight;
            FrontSprite = frontSprite;
            PokedexEntries = pokedexEntries;
            converter = new PokeApiNameConverter();
        }

        public bool HasSecondType() => Type2 != null;

        public string GetPokedexEntry(string version) => PokedexEntries[version];
    }
}
