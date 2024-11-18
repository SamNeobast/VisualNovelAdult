using UnityEngine;
using UnityEngine.UI;

public class QuestLogUI : MonoBehaviour
{
    public Text NameQuest;
    public Text Description; 

    private void OnEnable()
    {
        UpdateQuestLog();
    }

    public void UpdateQuestLog()
    {
        Quest activeQuest = QuestManager.Instance.GetActiveQuest();

        if (activeQuest != null)
        {
            NameQuest.text = activeQuest.questName;
            Description.text = activeQuest.questDescription;
        }
        else
        {
            NameQuest.text = "Немає Активних Квестів";
            Description.text = "Немає Активних Квестів.";
        }
    }
}
