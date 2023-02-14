using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOCounter")]
    [MethodDefinition("DOCounter", typeof(DOTweenModuleUI), typeof(Text), typeof(Int32), typeof(Int32), typeof(Single), typeof(Boolean), typeof(CultureInfo))]
    [Serializable]
    public class DOCounterScriptween : BaseScriptweenMethod
    {
        public Int32 fromValue;
        public Int32 endValue;
        public Single duration;
        public Boolean addThousandsSeparator;
        public CultureInfo culture;
    }
}