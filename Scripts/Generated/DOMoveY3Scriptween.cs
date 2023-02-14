using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMoveY<Rigidbody2D,Single,Single,Boolean>")]
    [MethodDefinition("DOMoveY", typeof(DOTweenModulePhysics2D), typeof(Rigidbody2D), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveY3Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}