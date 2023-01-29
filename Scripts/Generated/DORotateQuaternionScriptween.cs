using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORotateQuaternion")]
    [MethodDefinition("DORotateQuaternion", typeof(ShortcutExtensions), typeof(Transform), typeof(Quaternion), typeof(Single))]
    [Serializable]
    public class DORotateQuaternionScriptween : BaseScriptweenMethod
    {
        public Quaternion endValue;
        public Single duration;
    }
}