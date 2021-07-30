using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtticMaterialEstimator
{
    class AndrewInsulation : ITotalCost
    {
        public decimal JobSquareFeet { get; set; }
        public decimal SquareFootPerBag { get; } = 1m;
        public decimal PricePerBag { get; } = 1m;
        public decimal TotalCost { get; set; } = 0m;

        public void CalculateTotalCost()
        {
            TotalCost = (SquareFootPerBag * PricePerBag) * JobSquareFeet;
        }
    }
}
