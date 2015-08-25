using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimonlineDTO
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class SuspendSimcard
    {
        [DataMember(IsRequired=true)]
        [ApiMember(Description = "A list of imsi that will be suspended", IsRequired = true, DataType = "ARRAY[Unsigned int]", ParameterType = "body")]
        public IEnumerable<long> imsi { get; set; }

    }
}
