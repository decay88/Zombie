﻿using System;

namespace Zombie.Utilities
{
    public static class FrequencyUtils
    {
        /// <summary>
        /// Converts an enum Frequency into a TimeSpan object.
        /// </summary>
        /// <param name="frequency">Frequency object to convert.</param>
        /// <returns>New TimeSpan object.</returns>
        public static TimeSpan TimeSpanFromFrequency(Frequency frequency)
        {
            TimeSpan interval;
            switch (frequency)
            {
                case Frequency.min1:
                    interval = TimeSpan.FromSeconds(60);
                    break;
                case Frequency.min15:
                    interval = TimeSpan.FromMinutes(15);
                    break;
                case Frequency.min30:
                    interval = TimeSpan.FromMinutes(30);
                    break;
                case Frequency.h1:
                    interval = TimeSpan.FromHours(1);
                    break;
                case Frequency.h2:
                    interval = TimeSpan.FromHours(2);
                    break;
                case Frequency.h3:
                    interval = TimeSpan.FromHours(3);
                    break;
                case Frequency.h6:
                    interval = TimeSpan.FromHours(6);
                    break;
                case Frequency.h12:
                    interval = TimeSpan.FromHours(12);
                    break;
                case Frequency.h24:
                    interval = TimeSpan.FromHours(24);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return interval;
        }
    }
}
