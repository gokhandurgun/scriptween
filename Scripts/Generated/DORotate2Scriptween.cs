using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DORotate<Rigidbody,Vector3,Single,RotateMode>")]
    [MethodDefinition("DORotate", typeof(DOTweenModulePhysics), typeof(Rigidbody), typeof(Vector3), typeof(Single), typeof(RotateMode))]
    [Serializable]
    public class DORotate2Scriptween : BaseScriptweenMethod
    {
        public Vector3 endValue;
        public Single duration;
        public RotateMode mode;
    }
}