using System;
using System.Collections.Generic;
using System.Linq;

namespace Scriptweener
{
    [Serializable]
    public abstract class BaseScriptweenMethod
    {
        public IEnumerable<object> GetValues()
        {
            return this.GetType().GetFields().Select(x => x.GetValue(this));
        }
    }
    
}