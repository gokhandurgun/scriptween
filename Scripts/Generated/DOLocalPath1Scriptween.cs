using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOLocalPath<Transform,Vector3[],Single,PathType,PathMode,Int32,Nullable`1>")]
    [MethodDefinition("DOLocalPath", typeof(ShortcutExtensions), typeof(Transform), typeof(Vector3[]), typeof(Single), typeof(PathType), typeof(PathMode), typeof(Int32), typeof(Nullable<Color>))]
    [Serializable]
    public class DOLocalPath1Scriptween : BaseScriptweenMethod
    {
        public Vector3[] path;
        public Single duration;
        public PathType pathType;
        public PathMode pathMode;
        public Int32 resolution;
        public Nullable<Color> gizmoColor;
    }
}