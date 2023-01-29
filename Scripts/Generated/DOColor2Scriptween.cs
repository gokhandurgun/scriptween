using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Light,Color,Single>")]
    [MethodDefinition("DOColor", typeof(ShortcutExtensions), typeof(Light), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor2Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}