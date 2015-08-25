using Model.Api;
using ServiceStack;
using SimonlineDTO.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace SimonlineDTO
{
    [DataContract(Namespace = Constants.defaultNamespace)]
    public class AuthenticationResponse : IDTO
    {
        [DataMember(Order = 1, IsRequired = true)]
        public string username { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        public string session_id { get; set; }

        [DataMember(Order = 4, IsRequired = true)]
        public int domain_id { get; set; }

        [DataMember(Order = 5)]
        public string referrer_url { get; set; }

        [DataMember]
        [ApiAllowableValues("status", typeof(StatusCode))]
        [ApiMember(Description = "If the action was a partial_success or failed check error_details", IsRequired = true)]
        public string status { get; set; }

        [DataMember]
        [ApiMember(Description = "Description of all errors", DataType = "ARRAY[CommonError]", ParameterType = "body", IsRequired = true)]
        public List<CommonDetail> details { get; set; }

        public void SetStatus(StatusCode status)
        {
            this.status = status.ToString();
        }

        public void AddError(CommonDetail error)
        {
            if (details == null)
                details = new List<CommonDetail>();
            details.Add(error);
        }
    }
}