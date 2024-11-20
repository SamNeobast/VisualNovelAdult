using Naninovel;
using UnityEngine;

[CommandAlias("completeQuest")]
public class CompleteQuestCommand : Command
{
    [ParameterAlias("quest")]
    public StringParameter questName;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        Quest quest = Resources.Load<Quest>($"Quests/{questName}");
        if (quest != null)
        {
            QuestManager.Instance.RemoveQuest(quest);

            // Оновлюємо UI
            var questLogUI = Object.FindObjectOfType<QuestLogUI>();
            if (questLogUI != null)
                questLogUI.UpdateQuestLog();
        }

        return UniTask.CompletedTask;
    }
}