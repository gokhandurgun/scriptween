using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPunchAnchorPos")]
    [MethodDefinition("DOPunchAnchorPos", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector2), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOPunchAnchorPosScriptween : BaseScriptweenMethod
    {
        public Vector2 punch;
        public Single duration;
        public Int32 vibrato;
        public Single elasticity;
        public Boolean snapping;
    }
}