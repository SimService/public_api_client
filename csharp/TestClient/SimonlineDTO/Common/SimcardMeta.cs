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
    public class SimcardMeta
    {
        [DataMember]
        [ApiMember(Description = "Imsi that failed getting queued, because of current error", 
            DataType = "Unsigned integer", ParameterType = "body", IsRequired = false)]
        public decimal imsi { get; set; }
    }
}
