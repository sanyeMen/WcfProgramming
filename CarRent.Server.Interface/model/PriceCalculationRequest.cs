using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Server.Interface.model
{
    [DataContract]
    public class PriceCalculationRequest
    {
        [DataMember(Name="PickupDate", IsRequired=true, Order=1, EmitDefaultValue=false)]
        public DateTime PickupDate { get; set; }

        [DataMember]
        public DateTime ReturnDate { get; set; }

        [DataMember]
        public string PickupLocation { get; set; }

        [DataMember]
        public string ReturnLocation { get; set; }

        [DataMember]
        private string VehicleType { get; set; }

        [IgnoreDataMember]
        public string Color { get; set; }

    }
}
