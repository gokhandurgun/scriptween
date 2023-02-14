using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOValue")]
    [MethodDefinition("DOValue", typeof(DOTweenModuleUI), typeof(Slider), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOValueScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}