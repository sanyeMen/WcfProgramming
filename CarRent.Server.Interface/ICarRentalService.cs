using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Net.Security;
using CarRent.Server.Interface.model;

namespace CarRent.Server.Interface
{
    /// <summary>
    /// 要定义一个服务契约，只需要在定义接口时使用ServiceContract特性
    /// 并给每个将要在WSDL文档中公开为服务操作的方法添加一个OperationContract特性
    /// </summary>
    [ServiceContract(Namespace = "http://127.0.0.1:8001/CarRentalService", Name = "CarRentalService")]
    public interface ICarRentalService
    {
        [OperationContract(Name="GetPrice")]
        double CalculatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePreference);

        [OperationContract(Name="GetPriceOverloaded")]
        double CaculatePrice(string pickupLocation, string vehiclePreference);

        /// <summary>
        /// 单工操作
        /// </summary>
        /// <param name="vehicleId"></param>
        /// <param name="newPirce"></param>
        [OperationContract(IsOneWay=true, ProtectionLevel=ProtectionLevel.None)]
        void UpdatePrice(string vehicleId, double newPirce);

        [OperationContract]
        PriceCalculationResponse CaculatePrice(PriceCalculationRequest request);

    }
}
