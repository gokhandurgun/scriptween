using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalJump")]
    [MethodDefinition("DOLocalJump", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOLocalJumpScriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single jumpPower;
        public Int32 numJumps;
        public Single duration;
        public Boolean snapping;
    }
}