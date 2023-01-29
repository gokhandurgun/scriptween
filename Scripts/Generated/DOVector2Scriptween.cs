using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOVector<Material,Vector4,Int32,Single>")]
    [MethodDefinition("DOVector", typeof(ShortcutExtensions), typeof(Material), typeof(Vector4), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOVector2Scriptween : BaseScriptweenMethod
    {
        public Vector4 endValue;
        public Int32 propertyID;
        public Single duration;
    }
}