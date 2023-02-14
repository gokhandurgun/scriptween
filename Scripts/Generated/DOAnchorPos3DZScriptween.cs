using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAnchorPos3DZ")]
    [MethodDefinition("DOAnchorPos3DZ", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOAnchorPos3DZScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}