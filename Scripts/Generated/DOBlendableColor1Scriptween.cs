using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<Light,Color,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(ShortcutExtensions), typeof(Light), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOBlendableColor1Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}