using ServiceStack;
using System.Runtime.Serialization;

namespace SimonlineDTO.Network
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class Scheduled
    {
        [DataMember(IsRequired = true)]
        [ApiMember(Description = "All future networkchanges in the queue for a SINGLE imsi", IsRequired = true, DataType = "Unsigned integer", ParameterType = "body")]
        public long imsi { get; set; }
    }
}
