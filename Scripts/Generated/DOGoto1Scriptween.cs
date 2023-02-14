using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOGoto<Material,Single,Boolean>")]
    [MethodDefinition("DOGoto", typeof(ShortcutExtensions), typeof(Material), typeof(Single), typeof(Boolean))]
    [Serializable]
    public class DOGoto1Scriptween : BaseScriptweenMethod
    {
        public Single to;
        public Boolean andPlay;
    }
}