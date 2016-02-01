using ServiceStack;
using System.Runtime.Serialization;

namespace SimonlineDTO.Network
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class Empty
    {
        [DataMember(IsRequired = true)]
        [ApiMember(Description = "A simcard to have all future networkchanges removed from queue", IsRequired = true, DataType = "Unsigned integer", ParameterType = "body")]
        public long imsi { get; set; }
    }
}
