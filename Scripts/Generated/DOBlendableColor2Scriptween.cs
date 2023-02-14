using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<Material,Color,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(ShortcutExtensions), typeof(Material), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOBlendableColor2Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}