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
            UpdateProperty(nameof(ProductName));
            UpdateProperty(nameof(Description));
        }
        public Product Data { get => _product; set => _product = value; }
        public ProductViewModel(Product prod)
        {
            _product = prod;
        }
        public int Id => _product.Id;
        public string ProductName => _product.Name;
        public string Unit => _product.UnitQty.SingularName;
        public string Ingredients => _product.Recipes.Count > 1 ? (_product.Recipes.Count + " ingredients") : (_product.Recipes.Count + " ingredient");
        public string Description => _product.Description ?? "*no description available";
        public string Barcode => _product.Barcode ?? "*not set";
    }
}
