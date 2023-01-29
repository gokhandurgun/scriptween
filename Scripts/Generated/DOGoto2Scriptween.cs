using System;
using UnityEngine;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOGoto<Material,Single,Boolean>")]
    [MethodDefinition("DOGoto", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOGoto2Scriptween : BaseScriptweenMethod
    {
        public Single to;
        public Boolean andPlay;
    }
}