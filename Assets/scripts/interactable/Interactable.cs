using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public GameObject promptUI; // The "E" icon
    public UnityEvent onInteract; // Drag actions into this in Inspector!

    void Start()
    {
        if (promptUI != null)
            promptUI.SetActive(false);
    }

    public virtual void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        onInteract?.Invoke(); // Call whatever is hooked up
    }

    public void ShowPrompt(bool show)
    {
        if (promptUI != null)
            promptUI.SetActive(show);
    }
}
