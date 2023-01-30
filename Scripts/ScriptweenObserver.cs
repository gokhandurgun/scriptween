using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Scriptweener
{
    [Serializable]
    public class ScriptweenObserver
    {
        [SerializeReference]
        public List<IBaseScriptweenEntry> Listeners;

        public IEnumerable<Tween> InvokeAll()
        {
            var retVal = new List<Tween>();
            foreach (var e in Listeners)
            {
                retVal.Add(e.GetEntryOptions()?.PlayTween(e.GetScriptween()));
            }

            return retVal;
        }

#if UNITY_EDITOR
        public List<Tween> Tweens = new List<Tween>();
#endif
    }
}