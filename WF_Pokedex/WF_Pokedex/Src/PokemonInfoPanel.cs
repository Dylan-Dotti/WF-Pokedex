using PokeApi;
using StringExtensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WF_Pokedex
{
    public class PokemonInfoPanel
    {
        private readonly Label idLabel;
        private readonly Label nameLabel;
        private readonly Label genusLabel;
        private readonly Label typeLabel;
        private readonly Label heightLabel;
        private readonly Label weightLabel;
        private readonly PictureBox spriteBox;
        private readonly Label pokedexEntryLabel;

        public PokemonInfoPanel(Label idLabel, Label nameLabel, 
            Label genusLabel, Label typeLabel, Label heightLabel,
            Label weightLabel, PictureBox spriteBox, Label pokedexEntryLabel)
        {
            this.idLabel = idLabel;
            this.nameLabel = nameLabel;
            this.genusLabel = genusLabel;
            this.typeLabel = typeLabel;
            this.heightLabel = heightLabel;
            this.weightLabel = weightLabel;
            this.spriteBox = spriteBox;
            this.pokedexEntryLabel = pokedexEntryLabel;
        }

        public void DisplayPokemon(Pokemon pokemon)
        {
            nameLabel.Text = pokemon.DisplayName;
            string idString = pokemon.Id.ToString();
            while (idString.Length < 3)
            {
                idString = "0" + idString;
            }
            idString = "#" + idString;
            idLabel.Text = idString;
            genusLabel.Text = pokemon.Genus;
            typeLabel.Text = pokemon.Type1.Capitalize() + 
                (pokemon.HasSecondType() ? " / " + 
                 pokemon.Type2.Capitalize() : "");
            heightLabel.Text = pokemon.Height + " m";
            weightLabel.Text = pokemon.Weight + " kg";
            spriteBox.Image = pokemon.FrontSprite;
            pokedexEntryLabel.Text = pokemon.PokedexEntries[
                pokemon.PokedexEntries.Keys.First()];
        }
    }
}
