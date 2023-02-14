using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Outline,Color,Single>")]
    [MethodDefinition("DOColor", typeof(DOTweenModuleUI), typeof(Outline), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor10Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}