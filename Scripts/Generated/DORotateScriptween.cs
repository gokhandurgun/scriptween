using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORotate")]
    [MethodDefinition("DORotate", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(RotateMode))]
    [Serializable]
    public class DORotateScriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public RotateMode mode;
    }
}