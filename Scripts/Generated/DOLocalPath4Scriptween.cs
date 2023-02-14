using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalPath<Rigidbody2D,Vector2[],Single,PathType,PathMode,Int32,Nullable`1>")]
    [MethodDefinition("DOLocalPath", typeof(DOTweenModulePhysics2D), typeof(Rigidbody2D), typeof(Vector2[]), typeof(Single), typeof(PathType), typeof(PathMode), typeof(Int32), typeof(Nullable<Color>))]
    [Serializable]
    public class DOLocalPath4Scriptween : BaseScriptweenMethod
    {
        public Vector2[] path;
        public Single duration;
        public PathType pathType;
        public PathMode pathMode;
        public Int32 resolution;
        public Nullable<Color> gizmoColor;
    }
}