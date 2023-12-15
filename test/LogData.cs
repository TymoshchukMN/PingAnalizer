using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingAnalizer
{
    internal class LogData
    {
        public LogData(string dateTime, double delayTime)
        {
            Time = dateTime;
            DelayTime = delayTime;
        }

        public string Time { get; set; }

        public double DelayTime { get; set; }

        public ushort DelyTime { get; }
    }
}
