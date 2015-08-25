using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimonlineDTO.Common
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class CommonDetail
    {
        [DataMember]
        [ApiMember(Description = "Short error message", IsRequired = true)]
        public string simple { get; set; }

        [DataMember]
        [ApiMember(Description = "Full description of error", IsRequired = true)]
        public string message { get; set; }
    }
}
