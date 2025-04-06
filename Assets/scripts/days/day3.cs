using UnityEngine;

public class Day3 : MonoBehaviour
{
    public QuestMaker questMaker;

    void Start()
    {
        if (questMaker != null)
        {
            questMaker.Day3();
        }
        else
        {
            Debug.LogWarning("QuestMaker not assigned to Day1 script.");
        }
    }
}
