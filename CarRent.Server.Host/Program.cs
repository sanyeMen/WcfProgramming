using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CarRent.Server.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost carRentHost = new ServiceHost(typeof(CarRent.Server.Impl.CarRentalService));
        }
    }
}
