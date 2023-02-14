using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAnchorPos3DY")]
    [MethodDefinition("DOAnchorPos3DY", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOAnchorPos3DYScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}