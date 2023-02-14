using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOAnchorMin")]
    [MethodDefinition("DOAnchorMin", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector2), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOAnchorMinScriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
        public Boolean snapping;
    }
}