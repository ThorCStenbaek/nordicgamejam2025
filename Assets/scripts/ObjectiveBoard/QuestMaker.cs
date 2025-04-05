using UnityEngine;

public class QuestMaker : MonoBehaviour
{
    public ObjectiveUI objectiveUI;

    void Start()
    {
        if (objectiveUI == null)
        {
            Debug.LogWarning("ObjectiveUI reference not set in QuestMaker.");
            return;
        }

        // Add initial objectives using string keys
        objectiveUI.AddObjective("KEY", "Find the apartment key");
        objectiveUI.AddObjective("POWER", "Turn on the power");
    }

    public void OnKeyPickup()
    {
        objectiveUI.CompleteObjective("KEY");
    }

    public void OnPowerActivated()
    {
        objectiveUI.CompleteObjective("POWER");
    }
}
