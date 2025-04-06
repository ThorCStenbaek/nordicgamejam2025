using UnityEngine;

public class Day1 : MonoBehaviour
{
    public QuestMaker questMaker;

    void Start()
    {
        if (questMaker != null)
        {
            questMaker.Day1();
        }
        else
        {
            Debug.LogWarning("QuestMaker not assigned to Day1 script.");
        }
    }
}
