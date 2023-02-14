using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMove<Rigidbody2D,Vector2,Single,Boolean>")]
    [MethodDefinition("DOMove", typeof(DOTweenModulePhysics2D), typeof(Rigidbody2D), typeof(Vector2), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMove3Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
        public Boolean snapping;
    }
}