using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Plugins.Core.PathCore;

namespace Scriptweener
{
    [System.ComponentModel.Description("DOComplete<Material,Boolean>")]
    [MethodDefinition("DOComplete", typeof(ShortcutExtensions), typeof(Material), typeof(Boolean))]
    [Serializable]
    public class DOComplete2Scriptween : BaseScriptweenMethod
    {
        public Boolean withCallbacks;
    }
}