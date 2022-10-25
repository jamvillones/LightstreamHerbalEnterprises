using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.ViewModels
{
    internal sealed class RecipeViewModel : ViewModelBase, IViewmodelDataHolder<Recipe>
    {
        Recipe _recipe;
        public Recipe Data
        {
            get => _recipe;
            set
            {
                _recipe = value;
                UpdateValues();
            }
        }
        public RecipeViewModel(Recipe data)
        {
            Data = data;
        }

        public void UpdateValues()
        {
            UpdateProperty(nameof(DisplayMember));
        }

        public decimal Qty => Data.Qty;
        public string Unit => Data.GetUnit;
        public string Ingredient => Data.Ingredient.Name;

        public string DisplayMember => _recipe.DisplayMember;

    }
}
