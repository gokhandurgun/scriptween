using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFade<Material,Single,Int32,Single>")]
    [MethodDefinition("DOFade", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOFade3Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Int32 propertyID;
        public Single duration;
    }
}