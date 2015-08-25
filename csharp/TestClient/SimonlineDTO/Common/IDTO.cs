using Model.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonlineDTO.Common
{
    public interface IDTO
    {
        void SetStatus(StatusCode status);
        void AddError(CommonDetail error);
    }
}
