using UnityEngine;
using Naninovel;

[CommandAlias("addQuest")]
public class AddQuestCommand : Command
{
    [ParameterAlias("quest")]
    public StringParameter questName;

    public override UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        Quest quest = Resources.Load<Quest>($"Quests/{questName}");
        if (quest != null)
        {
            Debug.Log(questName.ToString());

            QuestManager.Instance.AddQuest(quest);

            // Оновлюємо UI
            var questLogUI = Object.FindObjectOfType<QuestLogUI>();
            if (questLogUI != null)
                questLogUI.UpdateQuestLog();
        }

        return UniTask.CompletedTask;
    }
}

