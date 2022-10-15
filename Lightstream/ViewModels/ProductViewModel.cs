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
    internal sealed class ProductViewModel :ViewModelBase , IViewmodelDataHolder<Product>
    {
        Product _product;        
        public void UpdateValues()
        {
            Update(nameof(Id));
            Update(nameof(ProductName));
            Update(nameof(Description));
        }
        public Product Data { get => _product; set => _product = value; }
        public ProductViewModel(Product prod)
        {
            _product = prod;
        }
        public int Id => _product.Id;
        public string ProductName => _product.Name;
        public string Description => _product.Description;

    }
}
