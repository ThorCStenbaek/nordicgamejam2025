using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene switching

public class QuestMaker : MonoBehaviour
{
    public ObjectiveUI objectiveUI;

    [Tooltip("Name of the scene to load when all objectives are completed.")]
    public string sceneToLoadOnComplete;

    void Start()
    {
        if (objectiveUI == null)
        {
            Debug.LogWarning("ObjectiveUI reference not set in QuestMaker.");
            return;
        }

        // Set the callback for when all objectives are complete
        objectiveUI.SetOnAllObjectivesCompleteCallback(OnAllObjectivesComplete);

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

    private void OnAllObjectivesComplete()
    {
        Debug.Log("All objectives completed!");

        if (!string.IsNullOrEmpty(sceneToLoadOnComplete))
        {
            Debug.Log($"Loading scene: {sceneToLoadOnComplete}");
            SceneManager.LoadScene(sceneToLoadOnComplete);
        }
        else
        {
            Debug.Log("No scene specified to load.");
        }
    }
}
