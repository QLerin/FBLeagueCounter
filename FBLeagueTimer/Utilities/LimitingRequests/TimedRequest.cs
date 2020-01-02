using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.Utilities.LimitingRequests
{
    public class TimedRequest
    {
        public TimedRequest(DateTime requestResolveTime)
        {
            RequestResolveTime = requestResolveTime;
        }

        public DateTime RequestResolveTime { set; get; }
    }
}
