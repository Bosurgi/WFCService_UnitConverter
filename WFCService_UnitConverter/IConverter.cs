using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WFCService_UnitConverter
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IConverter
    {

        [OperationContract]
        double ConvertMilesToKm(double miles);
        
        [OperationContract]
        double ConvertFeetToMeters(double feet);

        [OperationContract]
        double ConvertInchesToCentimeters(double inches);

        [OperationContract]
        double ConvertPoundsToKilograms(double pounds);
    }
}
