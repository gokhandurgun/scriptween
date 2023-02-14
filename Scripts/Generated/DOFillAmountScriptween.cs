using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFillAmount")]
    [MethodDefinition("DOFillAmount", typeof(DOTweenModuleUI), typeof(Image), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFillAmountScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}