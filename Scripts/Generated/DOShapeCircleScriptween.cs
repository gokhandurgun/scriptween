using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShapeCircle")]
    [MethodDefinition("DOShapeCircle", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Vector2), typeof(Single), typeof(Single), typeof(Boolean), typeof(Boolean))]
    [Serializable]
    public class DOShapeCircleScriptween : BaseScriptweenMethod
    {
        public Vector2 center;
        public Single endValueDegrees;
        public Single duration;
        public Boolean relativeCenter;
        public Boolean snapping;
    }
}