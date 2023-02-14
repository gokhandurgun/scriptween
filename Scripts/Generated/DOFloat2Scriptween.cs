using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOFloat<Material,Single,Int32,Single>")]
    [MethodDefinition("DOFloat", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(Int32), typeof(Single))]
    [Serializable]
    public class DOFloat2Scriptween : BaseScriptweenMethod
    {
        public Single endValue;
        public Int32 propertyID;
        public Single duration;
    }
}