using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORotate<Rigidbody2D,Single,Single>")]
    [MethodDefinition("DORotate", typeof(DOTweenModulePhysics2D), typeof(Rigidbody2D), typeof(Single), typeof(Single))]
    [Serializable]
    public class DORotate3Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
    }
}