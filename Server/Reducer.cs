using Blazor.Realm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public static class Reducer
    {
        public static AppState RootReducer(AppState appState, IRealmAction action) 
        {
            if (appState == null)
            {
                throw new ArgumentNullException(nameof(appState));
            }
            return new AppState
            {
                
                Count = CounterReducer(appState.Count, action)
               
            };

        }
        public static int CounterReducer(int count, IRealmAction action)
        {
            switch (action)
            {
                case Actions.IncrementByOne _:
                    return count + 1;
                case Actions.IncrementByValue a:
                    return count + a.Value;
                case Actions.DecrementByOne _:
                    return count - 1;
                case Actions.DecrementByValue a:
                    return count - a.Value;
                case Actions.ResetCount _:
                    return 0;
                default:
                    return count;
            }
        }
    }
}
