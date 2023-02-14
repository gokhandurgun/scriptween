using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMoveX<Rigidbody,Single,Single,Boolean>")]
    [MethodDefinition("DOMoveX", typeof(DOTweenModulePhysics), typeof(Rigidbody), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveX2Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}