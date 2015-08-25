using ServiceStack;
using SimonlineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimonlineDTO
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class Authentication{

        [DataMember(Order = 1, IsRequired = true)]
        [ApiMember(IsRequired = true, ParameterType = "body")]
        public string username { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        [ApiMember(IsRequired = true, ParameterType = "body")]
        public string password { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        [ApiMember(IsRequired = true, DataType="Integer" ,ParameterType = "body")]
        public int? domain_id{ get; set; }
        
    }
}
