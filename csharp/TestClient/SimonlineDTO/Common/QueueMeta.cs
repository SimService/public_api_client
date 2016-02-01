using ServiceStack;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SimonlineDTO.Common
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class QueueMeta
    {
        [DataMember]
        [ApiMember(DataType = "Unsigned integer", ParameterType = "body", IsRequired = false)]
        public long? imsi { get; set; }


        [DataMember]
        [ApiMember(DataType = "Unsigned integer", ParameterType = "body", IsRequired = false)]
        public List<long> id { get; set; }
    }
}
