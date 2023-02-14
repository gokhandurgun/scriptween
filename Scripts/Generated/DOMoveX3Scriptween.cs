using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMoveX<Rigidbody2D,Single,Single,Boolean>")]
    [MethodDefinition("DOMoveX", typeof(DOTweenModulePhysics2D), typeof(Rigidbody2D), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveX3Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}