using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShakePosition<Camera,Single,Vector3,Int32,Single,Boolean>")]
    [MethodDefinition("DOShakePosition", typeof(ShortcutExtensions), typeof(Camera), typeof(Single), typeof(Vector3), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOShakePosition2Scriptween : BaseScriptweenMethod
    {
        public Single duration;
        public Vector3 strength;
        public Int32 vibrato;
        public Single randomness;
        public Boolean fadeOut;
    }
}