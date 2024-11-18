using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "Quest/Quest")]
public class Quest : ScriptableObject
{
    public string questName;
    public string questDescription;
    public QuestTask[] tasks;

    public bool IsCompleted
    {
        get
        {
            foreach (var task in tasks)
            {
                if (!task.isCompleted) return false;
            }
            return true;
        }
    }
}
