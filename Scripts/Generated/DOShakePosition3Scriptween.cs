using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShakePosition<Transform,Single,Single,Int32,Single,Boolean,Boolean>")]
    [MethodDefinition("DOShakePosition", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean), typeof(Boolean))]
    [Serializable]
    public class DOShakePosition3Scriptween : BaseScriptweenMethod
    {
        public Single duration;
        public Single strength;
        public Int32 vibrato;
        public Single randomness;
        public Boolean snapping;
        public Boolean fadeOut;
    }
}