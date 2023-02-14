using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<Image,Color,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(DOTweenModuleUI), typeof(Image), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOBlendableColor7Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}