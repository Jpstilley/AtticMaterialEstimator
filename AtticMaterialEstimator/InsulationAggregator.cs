using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtticMaterialEstimator
{
    class InsulationAggregator 
    {

        public decimal AggregatePrices(List<ITotalCost> totalCosts)
        {
            decimal tempCost = 0;
            foreach (ITotalCost totalCost in totalCosts)
            {
                tempCost += totalCost.TotalCost;   
            }
            return tempCost;
        }
    }
}
