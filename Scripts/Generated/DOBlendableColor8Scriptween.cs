using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOBlendableColor<Text,Color,Single>")]
    [MethodDefinition("DOBlendableColor", typeof(DOTweenModuleUI), typeof(Text), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOBlendableColor8Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}