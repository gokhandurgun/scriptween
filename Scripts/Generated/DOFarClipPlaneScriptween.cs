using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFarClipPlane")]
    [MethodDefinition("DOFarClipPlane", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFarClipPlaneScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}