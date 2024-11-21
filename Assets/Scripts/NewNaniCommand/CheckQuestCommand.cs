using Naninovel;

[CommandAlias("checkQuest")]
public class CheckQuestCommand : Command
{
    [ParameterAlias("name")]
    public StringParameter QuestName; 

    [ParameterAlias("gotoIfTrue")]
    public StringParameter GotoIfTrue;

    [ParameterAlias("gotoIfTrueLabel")]
    public StringParameter GotoIfTrueLabel;

    [ParameterAlias("gotoIfFalse")]
    public StringParameter GotoIfFalse;

    [ParameterAlias("gotoIfFalseLabel")]
    public StringParameter GotoIfFalseLabel;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        var quest = QuestManager.Instance.FindQuestByName(QuestName.Value);
        if (quest != null) 
        {
            if (!string.IsNullOrEmpty(GotoIfTrue))
                Engine.GetService<IScriptPlayer>().PreloadAndPlayAsync(GotoIfTrue.Value, label: GotoIfTrueLabel).Forget();
        }
        else 
        {
            if (!string.IsNullOrEmpty(GotoIfFalse))
                Engine.GetService<IScriptPlayer>().PreloadAndPlayAsync(GotoIfFalse.Value, label: GotoIfFalseLabel).Forget();
        }

        return UniTask.CompletedTask;
    }
}