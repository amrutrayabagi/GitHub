using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<MessageContractExample> GetEmployees(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [ServiceContract]
    interface IGenericContract<T>
    {
        [OperationContract]
        T Add(T a, T b);
    }

    //class GerericConcreteClass<T> : IGenericContract<T>
    //{

    //    public T Add(T a, T b)
    //    {
    //        return a + b;
    //        //return a + b;
    //    }
    //}


    //// AMRUT RAYABAGI TODAY GOIING TO GADAG ON 

    //class GoogleClient : IGenericContract<T>
    //{

    //}
}
