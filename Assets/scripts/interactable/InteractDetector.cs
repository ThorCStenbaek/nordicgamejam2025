using UnityEngine;

public class InteractDetector : MonoBehaviour
{
    public float interactRange = 3f;
    public LayerMask interactableMask;

    private Interactable currentInteractable;

    void Update()
    {
        // Cast ray from the camera forward
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactRange, interactableMask))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                if (currentInteractable != interactable)
                {
                    if (currentInteractable != null)
                        currentInteractable.ShowPrompt(false);

                    currentInteractable = interactable;
                    currentInteractable.ShowPrompt(true);
                }

                if (Input.GetKeyDown(KeyCode.E))
                {
                    currentInteractable.Interact();
                }

                return;
            }
        }

        // Hide prompt when not looking at interactable
        if (currentInteractable != null)
        {
            currentInteractable.ShowPrompt(false);
            currentInteractable = null;
        }
    }

    void OnDisable()
    {
        if (currentInteractable != null)
        {
            currentInteractable.ShowPrompt(false);
            currentInteractable = null;
        }
    }
}
