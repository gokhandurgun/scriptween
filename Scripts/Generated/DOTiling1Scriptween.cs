using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOTiling<Material,Vector2,Single>")]
    [MethodDefinition("DOTiling", typeof(ShortcutExtensions), typeof(Material), typeof(Vector2), typeof(Single))]
    [Serializable]
    public class DOTiling1Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
    }
}