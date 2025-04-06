using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectiveUI : MonoBehaviour
{
    [Header("UI References")]
    public GameObject objectiveEntryPrefab;
    public Transform objectiveListParent;

    private System.Action onAllObjectivesComplete;


    private Dictionary<string, Objective> objectives = new Dictionary<string, Objective>();

    public void AddObjective(string key, string text)
    {
        if (objectives.ContainsKey(key))
        {
            Debug.LogWarning($"Objective with key '{key}' already exists!");
            return;
        }

        GameObject newEntry = Instantiate(objectiveEntryPrefab, objectiveListParent);
        TextMeshProUGUI textComp = newEntry.GetComponent<TextMeshProUGUI>();

        textComp.text = "☐ " + text;

        objectives.Add(key, new Objective
        {
            text = text,
            completed = false,
            textComponent = textComp
        });
    }

    public void SetOnAllObjectivesCompleteCallback(System.Action callback)
{
    onAllObjectivesComplete = callback;
}


    public void CompleteObjective(string key)
{
    if (objectives.TryGetValue(key, out Objective obj) && !obj.completed)
    {
        obj.completed = true;
        obj.textComponent.text = $"<s>☑ {obj.text}</s>";

        CheckObjectivesCompletion();
    }
    else
    {
        Debug.LogWarning($"No objective found with key '{key}', or it's already completed.");
    }
}

private void CheckObjectivesCompletion()
{
    foreach (var obj in objectives.Values)
    {
        if (!obj.completed)
            return;
    }

    onAllObjectivesComplete?.Invoke();
}



    public void ClearObjectives()
    {
        foreach (var obj in objectives.Values)
        {
            if (obj.textComponent != null)
                Destroy(obj.textComponent.gameObject);
        }
        objectives.Clear();
    }

    private class Objective
    {
        public string text;
        public bool completed;
        public TextMeshProUGUI textComponent;
    }
}
