using System;
using DG.Tweening;

namespace Scriptweener
{
    [Serializable]
    public abstract class BaseScriptweenMethodOption
    {
        public abstract void Apply(Tween tween);
    }
    
}