using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    [FaultContract(typeof(ErrorHand))]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    //[ServiceContract(SessionMode = SessionMode.Allowed, ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign)]
    //public interface IGeneric<T>
    //{
    //    [OperationContract]
    //    T returnInt();
    //}

    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    //class Generic<T> : IGeneric<T>
    //{

    //    public int returnInt()
    //    {
    //        return 123;
    //    }

    //    T IGeneric<T>.returnInt()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType : IExtensibleDataObject
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



        [OnSerializedAttribute]
        void OnSerializingEvent(StreamingContext stream)
        {
            if (string.IsNullOrEmpty(this.StringValue))
            {
                this.StringValue = string.Empty;
            }
        }

        //[NonSerialized]
        //public CompositeType Type { get; set; }

        public ExtensionDataObject ExtensionData
        {
            get;
            set;
        }
    }

    //class MyClass : IFormatter, IDisposable
    //{

    //    public SerializationBinder Binder
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public StreamingContext Context
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public object Deserialize(System.IO.Stream serializationStream)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Serialize(System.IO.Stream serializationStream, object graph)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ISurrogateSelector SurrogateSelector
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }
    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public void Dispose()
    //    {

    //    }
    //}

    ////Generic data contract serializer.

    //class GenericDataContractSerializer<T> : XmlObjectSerializer
    //{
    //    DataContractSerializer mData;

    //    public override bool IsStartObject(System.Xml.XmlDictionaryReader reader)
    //    {
    //        return mData.IsStartObject(reader);
    //    }

    //    public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    ////Attruibutes.

    ////class DataAttribute : DataContractAttribute
    ////{

    ////}


    public class ErrorHand : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            throw new NotImplementedException();
        }
    }


}
