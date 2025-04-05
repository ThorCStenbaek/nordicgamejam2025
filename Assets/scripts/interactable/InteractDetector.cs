using UnityEngine;

public class InteractDetector : MonoBehaviour
{
    public float interactRange = 3f;
    public LayerMask interactableMask;

    private Interactable currentInteractable;

    void Update()

    
    {

            Debug.DrawRay(transform.position, transform.forward * interactRange, Color.red);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactRange, interactableMask))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                // Only update prompt if it's a different object
                if (currentInteractable != interactable)
                {
                    if (currentInteractable != null)
                        currentInteractable.ShowPrompt(false);

                    currentInteractable = interactable;
                    currentInteractable.ShowPrompt(true);
                }

                // Interact
                if (Input.GetKeyDown(KeyCode.E))
                {
                    currentInteractable.Interact();
                }

                return;
            }
        }

        // If we're not hitting anything interactable
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
