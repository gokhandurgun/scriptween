using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMoveY<Transform,Single,Single,Boolean>")]
    [MethodDefinition("DOMoveY", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveY1Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}