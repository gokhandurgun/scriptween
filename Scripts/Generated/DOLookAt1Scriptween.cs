using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLookAt<Transform,Vector3,Single,AxisConstraint,Nullable`1>")]
    [MethodDefinition("DOLookAt", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(AxisConstraint), typeof(Nullable<Vector3>))]
    [Serializable]
    public class DOLookAt1Scriptween : BaseScriptweenMethod
    {
        public Vector3 towards;
        public Single duration;
        public AxisConstraint axisConstraint;
        public Nullable<Vector3> up;
    }
}