using ServiceStack;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;

namespace Model.Api
{
    public class SimcardBasic
    {
        [ApiMember(IsRequired = true, DataType="Unsigned int")]
        public long imsi { get; set; }
        [DataMember]
        [ApiMember(IsRequired = true, DataType="int")]
        public int msisdn { get; set; }
        [DataMember]
        [ApiAllowableValues("status", typeof(NetworkStatus))]
        [ApiMember(Description = "The current networkstatus of the simcard", IsRequired = true)]
        public string status { get; set; }

        [ApiMember(IsRequired = true)]
        public string puk1 { get; set; }
        [ApiMember(IsRequired = true)]
        public string puk2 { get; set; }
        [ApiMember(IsRequired = true)]
        public string pin1 { get; set; }
        [ApiMember(IsRequired = true)]
        public string pin2 { get; set; }
        [DataMember]
        [ApiMember(Description = "If simcard is queued for a networkstatus change", IsRequired = true)]
        public bool queued { get; set; }
    }
}
