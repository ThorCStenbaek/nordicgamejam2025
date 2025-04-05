using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject ePrompt; // Drag your world-space "E" prompt here


void Start()
{
    if (ePrompt != null)
        ePrompt.SetActive(false);
}

    public virtual void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
    }

    public void ShowPrompt(bool show)
    {
        if (ePrompt != null)
            ePrompt.SetActive(show);
    }
}
