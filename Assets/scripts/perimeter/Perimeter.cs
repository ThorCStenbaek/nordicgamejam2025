using UnityEngine;
using UnityEngine.Events;

public class Perimeter : MonoBehaviour
{
    public UnityEvent onTriggerEnter; // Hook actions into this via the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player GameObject is tagged "Player"
        {
            Debug.Log("Player entered the trigger zone!");
            onTriggerEnter?.Invoke(); // Call whatever is hooked up
            Destroy(gameObject); // Destroy this trigger zone after activation
        }
    }
}
