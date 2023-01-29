using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMove")]
    [MethodDefinition("DOMove", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveScriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public Boolean snapping;
    }
}