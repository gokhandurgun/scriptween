using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOText")]
    [MethodDefinition("DOText", typeof(DOTweenModuleUI), typeof(Text), typeof(String), typeof(Single), typeof(Boolean), typeof(ScrambleMode), typeof(String))]
    [Serializable]
    public class DOTextScriptween : BaseScriptweenMethod
    {
        public String endValue;
        public Single duration;
        public Boolean richTextEnabled;
        public ScrambleMode scrambleMode;
        public String scrambleChars;
    }
}