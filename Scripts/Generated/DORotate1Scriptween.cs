using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORotate<Transform,Vector3,Single,RotateMode>")]
    [MethodDefinition("DORotate", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(RotateMode))]
    [Serializable]
    public class DORotate1Scriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public RotateMode mode;
    }
}