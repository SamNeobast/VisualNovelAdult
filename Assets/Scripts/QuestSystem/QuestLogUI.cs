using UnityEngine;
using UnityEngine.UI;

public class QuestLogUI : MonoBehaviour
{
    [SerializeField] private Text NameQuest;
    [SerializeField] private Text Description;

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
