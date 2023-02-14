using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPunchRotation")]
    [MethodDefinition("DOPunchRotation", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOPunchRotationScriptween : BaseScriptweenMethod
    {
        public Vector3 punch;
        public Single duration;
        public Int32 vibrato;
        public Single elasticity;
    }
}