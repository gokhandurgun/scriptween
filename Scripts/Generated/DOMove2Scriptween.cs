using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOMove<Rigidbody,Vector3,Single,Boolean>")]
    [MethodDefinition("DOMove", typeof(DOTweenModulePhysics), typeof(Rigidbody), typeof(Vector3), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOMove2Scriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public Boolean snapping;
    }
}