using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAnchorPos")]
    [MethodDefinition("DOAnchorPos", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector2), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOAnchorPosScriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
        public Boolean snapping;
    }
}