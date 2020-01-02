using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.Utilities.LimitingRequests
{
    public static class ShittyLimiter
    {
        private const int Limit = 90;
        private const double LimitSeconds = 120;

        private static List<TimedRequest> _timedRequests;

        public static void AddRequest()
        {
            if (_timedRequests == null)
            {
                _timedRequests = new List<TimedRequest>();
            }
            _timedRequests.Add(new TimedRequest(DateTime.UtcNow));
        }

        //TODO Yea, I know this is bad idea
        public static void DelayUntilAvailable()
        {
            if (_timedRequests == null || _timedRequests.Count == 0)
            {
                return;
            }

            while (_timedRequests.Count >= Limit)
            {
                var currentTime = DateTime.UtcNow;

                var requestsCopy = _timedRequests.ToList();
                foreach (var request in requestsCopy)
                {
                    if ((currentTime - request.RequestResolveTime).TotalSeconds > LimitSeconds)
                    {
                        _timedRequests.Remove(request);
                    }
                }

                if (_timedRequests.Count >= Limit)
                {
                    System.Diagnostics.Debug.WriteLine($"Reached limit. Current amount: {_timedRequests.Count}. {currentTime.Second.ToString()}");
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

    }
}
