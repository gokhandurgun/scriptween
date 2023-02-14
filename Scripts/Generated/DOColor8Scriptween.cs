using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOColor<Graphic,Color,Single>")]
    [MethodDefinition("DOColor", typeof(DOTweenModuleUI), typeof(Graphic), typeof(Color), typeof(Single))]
    [Serializable]
    public class DOColor8Scriptween : BaseScriptweenMethod
    {
        public Color endValue;
        public Single duration;
    }
}