using Model.Api;
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
    public class SimcardDetail
    {
        [DataMember]
        [ApiMember(Description = "Additional metadata information in this case the imsi, if a card could not be queued"
            , IsRequired = false, DataType = "{\"imsi\": Unsigned int}")]
        public SimcardMeta meta { get; set; }

        [DataMember]
        [ApiMember(Description = "Short error message", IsRequired = true)]
        public string simple { get; set; }

        [DataMember]
        [ApiMember(Description = "Full description of error", IsRequired = true)]
        public string message { get; set; }

    }
}
