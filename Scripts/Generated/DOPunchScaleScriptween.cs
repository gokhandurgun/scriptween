using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOPunchScale")]
    [MethodDefinition("DOPunchScale", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOPunchScaleScriptween : BaseScriptweenMethod
    {
        public Vector3 punch;
        public Single duration;
        public Int32 vibrato;
        public Single elasticity;
    }
}