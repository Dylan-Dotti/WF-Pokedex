using PokeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Pokedex
{
    class SearchAndSelectBox
    {
        public event Action<string> SelectedEvent;

        private readonly TextBox nameSearchBox;
        private readonly ListBox nameSelectBox;

        private readonly List<string> defaultItems;

        private readonly PokemonSpeciesService pokemonService;
        private readonly PokeApiNameConverter nameConvert;

        public SearchAndSelectBox(TextBox searchBox, ListBox selectionBox)
        {
            nameSearchBox = searchBox;
            nameSelectBox = selectionBox;

            nameSearchBox.TextChanged += OnSearchTextChanged;
            nameSelectBox.SelectedValueChanged += OnSelectionChanged;

            pokemonService = new PokemonSpeciesService();
            nameConvert = new PokeApiNameConverter();
            defaultItems = new List<string>();
            LoadPokemonNames();
        }

        public void SetSelectBoxEnabled(bool enabled)
        {
            nameSelectBox.Enabled = enabled;
        }

        private void OnSearchTextChanged(object sender, EventArgs e)
        {
            // filter select box items
            string searchText = nameSearchBox.Text;
            IEnumerable<string> itemsFiltered = searchText.Length == 0 ?
                defaultItems :
                defaultItems.Where(i => i.ToLower().Contains(searchText.ToLower())).ToList();
            nameSelectBox.Items.Clear();
            nameSelectBox.Items.AddRange(itemsFiltered.ToArray());
        }

        private void OnSelectionChanged(object sender, EventArgs e)
        {
            string selectedName = (string)nameSelectBox.SelectedItem;
            string apiName = nameConvert.GetApiName(selectedName);
            SelectedEvent?.Invoke(apiName);
        }

        private async void LoadPokemonNames()
        {
            nameSearchBox.Enabled = false;
            nameSelectBox.Enabled = false;
            nameSelectBox.Items.Clear();
            IReadOnlyList<string> names = await pokemonService.GetCategoryNames();
            // copy nameSelectBox items to default items
            foreach (string name in names)
            {
                string displayName = nameConvert.GetDisplayName(name);
                defaultItems.Add(displayName);
                nameSelectBox.Items.Add(displayName);
            }
            nameSearchBox.Enabled = true;
            nameSelectBox.Enabled = true;
        }
    }
}
