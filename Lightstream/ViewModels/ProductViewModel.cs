using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.ViewModels
{
    internal sealed class ProductViewModel : ViewModelBase, IViewmodelDataHolder<Product>
    {
        Product _product;
        public void UpdateValues()
        {
            UpdateProperty(nameof(Id));
            UpdateProperty(nameof(Barcode));
            UpdateProperty(nameof(ProductName));
            UpdateProperty(nameof(Description));
            UpdateProperty(nameof(Ingredients));
        }
        public Product Data
        {
            get => _product;
            set
            {
                _product = value;
                UpdateValues();
            }
        }
        public ProductViewModel(Product prod)
        {
            _product = prod;
        }
        public int Id => _product.Id;
        public string ProductName => _product.Name;
        public string Unit => _product.UnitQty.SingularName;
        //public string Ingredients => _product.Recipes.Count > 1 ? (_product.Recipes.Count + " ingredients") : (_product.Recipes.Count + " ingredient");
        public string Ingredients
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var r in _product.Recipes)
                    sb.AppendLine("● " + r.Qty.ToString().TrimEnd('0', '.') + " " + r.GetUnit + " " + r.Ingredient.Name);
                return sb.ToString();
            }
        }
        public string Description => _product.Description ?? string.Empty;
        public string Barcode => _product.Barcode ?? string.Empty;


    }
}
