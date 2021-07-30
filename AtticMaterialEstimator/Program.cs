using System;
using System.Collections.Generic;

namespace AtticMaterialEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            JoJoInsulation joJo = new JoJoInsulation();
            AndrewInsulation andrew = new AndrewInsulation();
            AddOns customer = new AddOns();
            InsulationAggregator insulationAggregator = new InsulationAggregator();
            customer.Quantity = 5;
            customer.CalculatedTotalCost();
            joJo.JobSquareFeet = 5m;
            joJo.CalculateTotalCost();
            andrew.JobSquareFeet = 5m;
            andrew.CalculateTotalCost();
            List<ITotalCost> totalCosts = new List<ITotalCost>();
            totalCosts.Add(joJo);
            totalCosts.Add(customer);
            totalCosts.Add(andrew);
            decimal jobTotal = insulationAggregator.AggregatePrices(totalCosts);

            Console.WriteLine(jobTotal);
        }
    }
}
