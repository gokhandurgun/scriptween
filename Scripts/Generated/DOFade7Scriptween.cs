using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<Image,Single,Single>")]
    [MethodDefinition("DOFade", typeof(DOTweenModuleUI), typeof(Image), typeof(Single), typeof(Single))]
    [Serializable]
    public class DOFade7Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}