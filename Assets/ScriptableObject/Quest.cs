using UnityEngine;

[CreateAssetMenu(fileName = "NewQuest", menuName = "Quest/Quest")]
public class Quest : ScriptableObject
{
    public int questID;
    public string questName;
    [TextArea] public string questDescription;
}
