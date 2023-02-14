using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOShakeAnchorPos<RectTransform,Single,Single,Int32,Single,Boolean,Boolean>")]
    [MethodDefinition("DOShakeAnchorPos", typeof(DOTweenModuleUI), typeof(RectTransform), typeof(Single), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean), typeof(Boolean))]
    [Serializable]
    public class DOShakeAnchorPos1Scriptween : BaseScriptweenMethod
    {
        public Single duration;
        public Single strength;
        public Int32 vibrato;
        public Single randomness;
        public Boolean snapping;
        public Boolean fadeOut;
    }
}