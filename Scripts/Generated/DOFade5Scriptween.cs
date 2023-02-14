using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<CanvasGroup,Single,Single>")]
    [MethodDefinition("DOFade", typeof(DOTweenModuleUI), typeof(CanvasGroup), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFade5Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}