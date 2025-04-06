using UnityEngine;

public class Activator : MonoBehaviour
{
    [Tooltip("The GameObject to activate if it's not already active.")]
    public GameObject target;

    public void ActivateIfInactive()
    {
        if (target != null && !target.activeSelf)
        {
            target.SetActive(true);
            Debug.Log($"{target.name} has been activated.");
        }
    }
}
