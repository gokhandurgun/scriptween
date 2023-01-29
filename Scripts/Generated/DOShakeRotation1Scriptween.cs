using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShakeRotation<Camera,Single,Single,Int32,Single,Boolean>")]
    [MethodDefinition("DOShakeRotation", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOShakeRotation1Scriptween : BaseScriptweenMethod
    {
        public Single duration;
        public Single strength;
        public Int32 vibrato;
        public Single randomness;
        public Boolean fadeOut;
    }
}