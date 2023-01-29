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
            foreach (var e in Listeners)
            {
                yield return e.GetEntryOptions()?.PlayTween(e.GetScriptween());
            }
        }

#if UNITY_EDITOR
        public List<Tween> Tweens = new List<Tween>();
#endif
    }
}