﻿using Model.Api;
using ServiceStack;
using SimonlineDTO;
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
    public class ActivateSimcardResponse : IDTO
    {
        [DataMember]
        [ApiMember(Description="Imsi from cards that have been successfully queued for activation", DataType="ARRAY[Unsigned Integer]", ParameterType="body", IsRequired=true)]
        public IEnumerable<long> queued { get; set; }

        [DataMember]
        [ApiAllowableValues("status", typeof(StatusCode))]
        [ApiMember(Description = "If the action was a partial_success or failed check error_details", IsRequired=true)]
        public string status { get; set; }

        [DataMember]
        [ApiMember(Description = "Description of all errors", DataType = "ARRAY[SimcardDetail]", ParameterType = "body", IsRequired = true)]
        public List<SimcardDetail> details { get; set; }


        public void SetStatus(StatusCode status)
        {
            this.status = status.ToString();
        }

        public void AddError(CommonDetail error)
        {
            if (details == null)
                details = new List<SimcardDetail>();
            details.Add(new SimcardDetail() { message = error.message, simple = error.simple });
        }
    }
}
