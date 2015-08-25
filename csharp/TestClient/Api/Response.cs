using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Api
{
    public class ApiResponse<T> where T : DetailedError 
    {
        public StatusCodeObject status { get; set; }

        public List<T> error_details { get; set; }
    }
}
