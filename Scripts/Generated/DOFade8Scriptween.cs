using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<Outline,Single,Single>")]
    [MethodDefinition("DOFade", typeof(DOTweenModuleUI), typeof(Outline), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFade8Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}