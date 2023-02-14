using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPivot")]
    [MethodDefinition("DOPivot", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector2), typeof(Single))]
    [Serializable]
    public class DOPivotScriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
    }
}