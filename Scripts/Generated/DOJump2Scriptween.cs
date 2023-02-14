using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOJump<Rigidbody,Vector3,Single,Int32,Single,Boolean>")]
    [MethodDefinition("DOJump", typeof(DOTweenModulePhysics), typeof(Rigidbody), typeof(Vector3), typeof(Single), typeof(Int32), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOJump2Scriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single jumpPower;
        public Int32 numJumps;
        public Single duration;
        public Boolean snapping;
    }
}