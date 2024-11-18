using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance; 

    public List<Quest> activeQuests = new List<Quest>(); 

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddQuest(Quest newQuest)
    {
        if (!activeQuests.Contains(newQuest))
            activeQuests.Add(newQuest);
    }

    public void RemoveQuest(Quest quest)
    {
        if (activeQuests.Contains(quest))
            activeQuests.Remove(quest);
    }

    public Quest GetActiveQuest()
    {
        return activeQuests.Count > 0 ? activeQuests[0] : null;
    }
}
