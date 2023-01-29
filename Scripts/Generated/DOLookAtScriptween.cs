using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLookAt")]
    [MethodDefinition("DOLookAt", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(AxisConstraint), typeof(Nullable<Vector3>))]
    [Serializable]
    public class DOLookAtScriptween : BaseScriptweenMethod
    {
        public Vector3 towards;
        public Single duration;
        public AxisConstraint axisConstraint;
        public Nullable<Vector3> up;
    }
}