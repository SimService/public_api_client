using Model.Api;
using ServiceStack;
using SimonlineDTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SimonlineDTO.Network
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class EmptyResponse
    {
        [DataMember]
        [ApiAllowableValues("status", typeof(StatusCode))]
        [ApiMember(Description = "If the action was a partial_success or failed check error_details", IsRequired = true)]
        public string status { get; set; }

        [DataMember]
        [ApiMember(Description = "If the action was a success it will contain the deleted id's from the queue", DataType="ARRAY[Unsigned integer]", IsRequired = false)]
        public List<long> deleted { get; set; }


        [DataMember]
        [ApiMember(Description = "Description of all errors", DataType = "ARRAY[QueueErrorDetail]", ParameterType = "body", IsRequired = true)]
        public List<QueueErrorDetail> details { get; set; }


    }
}
