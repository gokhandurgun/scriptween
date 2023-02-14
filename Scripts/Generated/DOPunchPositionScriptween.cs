using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPunchPosition")]
    [MethodDefinition("DOPunchPosition", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOPunchPositionScriptween : BaseScriptweenMethod
    {
        public Vector3 punch;
        public Single duration;
        public Int32 vibrato;
        public Single elasticity;
        public Boolean snapping;
    }
}