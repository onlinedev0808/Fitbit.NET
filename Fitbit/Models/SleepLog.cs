﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitbit.Models
{
    public class SleepLog
    {
        public int AwakeningsCount { get; set; }
        public int Duration { get; set; }
        public int Efficiency { get; set; }
        public bool IsMainSleep { get; set; }
        public int LogId { get; set; }
        public List<MinuteData> MinuteData { get; set; }
        public int MinutesAfterWakeup { get; set; }
        public int MinutesAsleep { get; set; }
        public int MinutesAwake { get; set; }
        public int MinutesToFallAsleep { get; set; }
        public DateTime StartTime { get; set; }
        public int TimeInBed { get; set; }
    }
}
