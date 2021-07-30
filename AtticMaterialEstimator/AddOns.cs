using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtticMaterialEstimator
{
    class AddOns : ITotalCost
    {
        public int Quantity { get; set; } = 0;
        public decimal Price { get; } = 1m;
        public decimal TotalCost { get; set; } = 0m;

        public void CalculatedTotalCost()
        {
            TotalCost = Quantity * Price;
        }

    }
}
