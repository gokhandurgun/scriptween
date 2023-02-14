using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMoveY<Rigidbody,Single,Single,Boolean>")]
    [MethodDefinition("DOMoveY", typeof(DOTweenModulePhysics), typeof(Rigidbody), typeof(Single), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMoveY2Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Single duration;
        public Boolean snapping;
    }
}