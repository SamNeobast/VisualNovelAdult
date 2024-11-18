using UnityEngine;

[CreateAssetMenu(fileName = "NewTask", menuName = "Quest/Task")]
public class QuestTask : ScriptableObject
{
    [Header("Task Details")]
    public string taskName;       
    public string description;    
    public bool isCompleted;     
}
