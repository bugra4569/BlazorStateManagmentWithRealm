using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public class AppState
    {
        public bool IsLoading { get; set; } = false;
        public int Count { get; set; } = 0;
    }
}
