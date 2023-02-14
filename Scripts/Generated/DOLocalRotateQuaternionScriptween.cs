using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalRotateQuaternion")]
    [MethodDefinition("DOLocalRotateQuaternion", typeof(ShortcutExtensions), typeof(Transform), typeof(Quaternion), typeof(Single))]
    [Serializable]
    public class DOLocalRotateQuaternionScriptween : BaseScriptweenMethod
    {
        public Quaternion endValue;
        public Single duration;
    }
}