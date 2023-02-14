using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMoveZ<Transform,Single,Single,Boolean>")]
    [MethodDefinition("DOMoveZ", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveZ1Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}