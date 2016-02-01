using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Model.Api;

namespace SimonlineDTO.Common
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class QueueErrorDetail
    {

        [DataMember]
        [ApiMember(Description = "Additional metadata information for the queue element which the error concerns", IsRequired = false)]
        public QueueMeta meta { get; set; }

        [DataMember]
        [ApiMember(Description = "Short error message", IsRequired = true)]
        public string simple { get; set; }

        [DataMember]
        [ApiMember(Description = "Full description of error", IsRequired = true)]
        public string message { get; set; }
    }
}
