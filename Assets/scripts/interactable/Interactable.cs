using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject promptUI; // Assign a world-space "E" icon

    void Start()
    {
        if (promptUI != null)
            promptUI.SetActive(false);
    }

    public virtual void Interact()
    {
        
        Debug.Log("Interacted with " + gameObject.name);
     if (TryGetComponent<Renderer>(out var renderer))
    {
        renderer.material.color = Color.green; // Change to green when interacted
    }

    }

    public void ShowPrompt(bool show)
    {
        if (promptUI != null)
            promptUI.SetActive(show);
    }
}
