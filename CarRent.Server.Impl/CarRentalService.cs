using CarRent.Server.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Server.Impl
{
    public class CarRentalService : ICarRentalService
    {
        public double CalculatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePreference)
        {
            Random rm = new Random(DateTime.Now.Millisecond);
            return rm.NextDouble() * 500;
        }


        public double CaculatePrice(string pickupLocation, string vehiclePreference)
        {
            Random rm = new Random(DateTime.Now.Millisecond);
            return rm.NextDouble() * 500;
        }

        public void UpdatePrice(string vehicleId, double newPirce)
        {
            
        }


        public Interface.model.PriceCalculationResponse CaculatePrice(Interface.model.PriceCalculationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
