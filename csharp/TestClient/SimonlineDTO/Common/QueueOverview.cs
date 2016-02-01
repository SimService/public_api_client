using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SimonlineDTO.Common
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class QueueOverview
    {

        [DataMember]
        [ApiMember(ParameterType = "body", DataType = "Unsigned integer", IsRequired = true)]
        public long imsi {get; set;}
        [DataMember]
        [ApiMember(ParameterType = "body", DataType = "ISO8601 Timestamp using UTC-0", IsRequired = true)]
        public DateTime scheduled { get; set; }
        [DataMember]
        [ApiMember(ParameterType = "body", Description = "possible values {scheduled, pending, retrying, warning, running, failed}", IsRequired = true)]
        public string status { get; set; }
        [DataMember]
        [ApiMember(ParameterType = "body", Description = "possible values {activation, service_addition, overrule, refresh, service_removal, suspension, termination, unsuspension, untermination, update, error}", IsRequired = true)]
        public string type { get; set; }
        [DataMember]
        [ApiMember(ParameterType = "body", DataType = "Unsigned integer", IsRequired = true)]
        public long id { get; set; }
    }
}
