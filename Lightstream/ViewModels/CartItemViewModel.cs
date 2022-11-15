using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.ViewModels
{
    internal class CartItemViewModel : ViewModelBase
    {
        private SoldProduct soldProduct;
        public SoldProduct GetData => soldProduct;
        public CartItemViewModel(SoldProduct sp)
        {
            soldProduct = sp;
        }
        public string ProductNumber => soldProduct.ProductNumber;
        public string ProductName => soldProduct.ProductName;
        public string Variation => soldProduct.Variation;


        public int Qty
        {
            get => soldProduct.SoldQty;
            set
            {
                soldProduct.SoldQty = value;
                UpdateProperty(nameof(Qty));
                UpdateProperty(nameof(Total));
            }

        }
        public decimal Price
        {
            get => soldProduct.SoldPrice;
            set
            {
                soldProduct.SoldPrice = value;
                UpdateProperty(nameof(Price));
                UpdateProperty(nameof(Total));
            }
        }

        public decimal Total => Qty * Price;
    }
}
