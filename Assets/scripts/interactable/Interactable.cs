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
        // You can override this in child classes for custom behavior
    }

    public void ShowPrompt(bool show)
    {
        if (promptUI != null)
            promptUI.SetActive(show);
    }
}
