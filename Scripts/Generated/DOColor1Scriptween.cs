using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Camera,Color,Single>")]
    [MethodDefinition("DOColor", typeof(ShortcutExtensions), typeof(Camera), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor1Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}