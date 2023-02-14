using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOJump<Rigidbody2D,Vector2,Single,Int32,Single,Boolean>")]
    [MethodDefinition("DOJump", typeof(DOTweenModulePhysics2D), typeof(Rigidbody2D), typeof(Vector2), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOJump3Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single jumpPower;
        public Int32 numJumps;
        public Single duration;
        public Boolean snapping;
    }
}