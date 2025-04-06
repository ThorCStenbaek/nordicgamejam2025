using UnityEngine;

public class Day2 : MonoBehaviour
{
    public QuestMaker questMaker;

    void Start()
    {
        if (questMaker != null)
        {
            questMaker.Day2();
        }
        else
        {
            Debug.LogWarning("QuestMaker not assigned to Day1 script.");
        }
    }
}
