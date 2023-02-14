using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPreferredSize")]
    [MethodDefinition("DOPreferredSize", typeof(DOTweenModuleUI), typeof(LayoutElement), typeof(Vector2), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOPreferredSizeScriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
        public Boolean snapping;
    }
}