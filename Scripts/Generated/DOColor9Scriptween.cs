using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Image,Color,Single>")]
    [MethodDefinition("DOColor", typeof(DOTweenModuleUI), typeof(Image), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor9Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}