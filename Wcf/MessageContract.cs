using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Wcf
{
    [MessageContract]
    public class MessageContractExample
    {
        [MessageHeader]
        public string OperationName { get; set; }
        [MessageHeader]
        public string SSN { get; set; }
        [MessageBodyMember]
        public string firstName { get; set; }
        [MessageBodyMember]
        public string lastName { get; set; }
        [MessageBodyMember]
        public string age { get; set; }
        [MessageBodyMember]
        public string companyName { get; set; }
    }
}