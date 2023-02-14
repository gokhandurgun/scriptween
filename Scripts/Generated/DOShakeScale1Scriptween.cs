using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShakeScale<Transform,Single,Single,Int32,Single,Boolean>")]
    [MethodDefinition("DOShakeScale", typeof(ShortcutExtensions), typeof(Transform), typeof(Single), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOShakeScale1Scriptween : BaseScriptweenMethod
    {
        public Single duration;
        public Single strength;
        public Int32 vibrato;
        public Single randomness;
        public Boolean fadeOut;
    }
}