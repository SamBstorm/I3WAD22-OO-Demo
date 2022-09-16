using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate2
{
    class AudioDisc
    {
        public int[] TrackTimes { get; private set; }

        public AudioDisc(params int[] tracktimes)
        {
            TrackTimes = tracktimes;
        }
    }
}
