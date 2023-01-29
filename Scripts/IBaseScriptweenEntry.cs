namespace Scriptweener
{
    public interface IBaseScriptweenEntry
    {
        IScriptween GetScriptween();

        BaseScriptweenEntryOptions GetEntryOptions();

#if UNITY_EDITOR
        void ScriptweenChanged();
#endif

    }
}
