﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Pokedex.PokeApiServices;

namespace WF_Pokedex
{
    public class PokemonFactory
    {
        private readonly PokemonSpeciesService speciesService;
        private readonly PokemonService pokemonService;
        private readonly HttpImageLoader imageLoader;

        public PokemonFactory()
        {
            speciesService = new PokemonSpeciesService();
            pokemonService = new PokemonService();
            imageLoader = new HttpImageLoader();
        }

        public async Task<Pokemon> CreatePokemon(string nameOrId)
        {
            JObject speciesData = await speciesService.GetById(nameOrId);
            JObject pokemonData = await pokemonService.GetById(nameOrId);
            string pkmName = pokemonData.Value<string>("name");
            int pkmId = pokemonData.Value<int>("id");
            string genus = GetGenus(speciesData);
            (string t1, string t2) = GetTypes(pokemonData);
            float height = GetHeightMeters(pokemonData);
            float weight = GetWeightKilograms(pokemonData);

            Dictionary<string, string> pokedexEntries =
                GetPokedexEntries(speciesData);
            /*foreach (KeyValuePair<string, string> versionDescrip in
                GetVersionDescriptions(speciesData))
            {
                Console.WriteLine(
                    $"{versionDescrip.Key} : {versionDescrip.Value}");
            }*/

            JObject spriteUrls = pokemonData.Value<JObject>("sprites");
            Image frontSprite = await imageLoader.LoadImage(
                spriteUrls.Value<string>("front_default"));
            return new Pokemon(pkmName, pkmId, genus, t1, t2,
                height, weight, frontSprite, pokedexEntries);
        }

        private string GetGenus(JObject speciesData)
        {
            JArray genera = speciesData.Value<JArray>("genera");
            JToken generaObject = genera.Where(g =>
            {
                JObject language = g.Value<JObject>("language");
                string lname = language.Value<string>("name");
                return lname == "en";
            }).First();
            return generaObject.Value<string>("genus");
        }

        private (string, string) GetTypes(JObject pkmData)
        {
            JArray types = pkmData.Value<JArray>("types");
            string[] typeNames = types.Select(
                t => t.Value<JObject>("type").Value<string>("name")).ToArray();
            string type1 = typeNames[0];
            string type2 = typeNames.Length == 2 ? typeNames[1] : null;
            return (type1, type2);
        }

        private float GetHeightMeters(JObject pkmData)
        {
            float heightDecimeters = pkmData.Value<float>("height");
            return (float)Math.Round(heightDecimeters / 10f, 2);
        }

        private float GetWeightKilograms(JObject pkmdata)
        {
            float weightHectograms = pkmdata.Value<float>("weight");
            return (float)Math.Round(weightHectograms / 10f, 2);
        }

        private Dictionary<string, string> GetPokedexEntries(JObject speciesData)
        {
            Dictionary<string, string> versionDescriptions = new Dictionary<string, string>();
            JArray flavorEntries = speciesData.Value<JArray>("flavor_text_entries");
            foreach (JObject entry in flavorEntries)
            {
                string language = GetLanguageName(entry);
                if (language == "en")
                {
                    string versionName = GetVersionName(entry);
                    string text = entry.Value<string>("flavor_text");
                    text = new PokedexEntryFormatter().FormatEntry(text);
                    versionDescriptions.Add(versionName, text);
                }
            }
            return versionDescriptions;
        }

        private string GetVersionName(JObject obj)
        {
            return obj.Value<JObject>("version").Value<string>("name");
        }

        private string GetLanguageName(JObject obj)
        {
            return obj.Value<JObject>("language").Value<string>("name");
        }
    }
}
