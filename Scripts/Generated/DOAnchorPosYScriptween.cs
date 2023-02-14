using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAnchorPosY")]
    [MethodDefinition("DOAnchorPosY", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOAnchorPosYScriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}