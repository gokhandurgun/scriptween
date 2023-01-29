using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOVector<Material,Vector4,String,Single>")]
    [MethodDefinition("DOVector", typeof(ShortcutExtensions), typeof(Material), typeof(Vector4), typeof(String), typeof(Single))]
    [Serializable]
    public class DOVector1Scriptween : BaseScriptweenMethod
    {
        public Vector4 endValue;
        public String property;
        public Single duration;
    }
}