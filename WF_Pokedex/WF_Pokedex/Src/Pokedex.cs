using PokeApi;
using System;
using System.Windows.Forms;

namespace WF_Pokedex
{
    public partial class PokedexForm : Form
    {
        private readonly SearchAndSelectBox sasBox;
        private readonly PokemonInfoPanel infoPanel;

        private readonly PokemonFactory pkmFactory;

        public PokedexForm()
        {
            InitializeComponent();
            sasBox = new SearchAndSelectBox(nameSearchBox, nameSelectionBox);
            sasBox.SelectedEvent += OnPokemonSelectionChanged;
            infoPanel = new PokemonInfoPanel(idLabel, nameLabel, 
                genusLabel, typeLabel, heightLabel, weightLabel, 
                spriteImageBox, descriptionLabel);
            pkmFactory = new PokemonFactory();
        }

        private async void OnPokemonSelectionChanged(string selectedName)
        {
            Console.WriteLine($"Loading: {selectedName}");
            sasBox.SetSelectBoxEnabled(false);
            Pokemon pokemon = await pkmFactory.CreatePokemon(selectedName);
            infoPanel.DisplayPokemon(pokemon);
            sasBox.SetSelectBoxEnabled(true);
        }
    }
}
