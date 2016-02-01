using Model.Api;
using ServiceStack;
using SimonlineDTO.Common;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SimonlineDTO.Network
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class ScheduledResponse
    {

        [DataMember]
        [ApiMember(Description = "Queue elements", ParameterType = "body", DataType = "ARRAY[QueueOverview]", IsRequired = false)]
        public List<QueueOverview> overview { get; set; }



        [DataMember]
        [ApiMember(Description = "Description of all errors", DataType = "ARRAY[QueueErrorDetail]", ParameterType = "body", IsRequired = false)]
        public List<QueueErrorDetail> details { get; set; }

    }
}
