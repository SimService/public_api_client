using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SimonlineDTO
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class TerminateSimcard
    {
        [DataMember(IsRequired = true)]
        [ApiMember(Description = "A list of imsi that will be terminated", IsRequired = true, DataType = "ARRAY[Unsigned integer]", ParameterType = "body")]
        public IEnumerable<long> imsi { get; set; }


        [DataMember(IsRequired = true)]
        [ApiMember(Description = "If the simcard should terminate when the current subscription ends. Defaults to false", IsRequired = true, DataType = "boolean", ParameterType = "body")]
        public bool at_subscription_end { get; set; }
    }
}
