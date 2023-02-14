using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalRotate")]
    [MethodDefinition("DOLocalRotate", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(RotateMode))]
    [Serializable]
    public class DOLocalRotateScriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public RotateMode mode;
    }
}