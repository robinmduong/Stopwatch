using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch
{ 
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public DateTime Start()
        {
            _startTime = DateTime.Now;
            return _startTime;
        }

        public DateTime Stop()
        {
            _endTime = DateTime.Now;
            return _endTime;
        }
    }
}
