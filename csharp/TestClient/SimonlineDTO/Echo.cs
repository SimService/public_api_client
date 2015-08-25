using Model.Api;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimonlineDTO
{
    [DataContract(Namespace=Constants.defaultNamespace)]
    public class Echo
    {
        [DataMember]
        public string shout { get; set; }
    }
}
