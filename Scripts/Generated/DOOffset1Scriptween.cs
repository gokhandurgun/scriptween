using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOOffset<Material,Vector2,Single>")]
    [MethodDefinition("DOOffset", typeof(ShortcutExtensions), typeof(Material), typeof(Vector2), typeof(Single))]
    [Serializable]
    public class DOOffset1Scriptween : BaseScriptweenMethod
    {
        public Vector2 endValue;
        public Single duration;
    }
}