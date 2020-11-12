using Blazor.Realm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public  class Actions
    {
        public class IncrementByOne : IRealmAction { }

        public class IncrementByValue : IRealmAction
        {
            public int Value { get; set; }
            public IncrementByValue(int value)
            {
                Value = value;
            }
        }

        public class DecrementByOne : IRealmAction { }

        public class DecrementByValue : IRealmAction
        {
            public int Value { get; set; }
            public DecrementByValue(int value)
            {
                Value = value;
            }
        }

        public class ResetCount : IRealmAction { }

        // WeatherForecasts Actions
        public class ClearWeatherForecasts : IRealmAction { }


    }
}
