using UnityEngine;

public class ErraticMover : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 1f;               // Base speed of movement
    public float moveRange = 1f;               // How far left/right it moves
    public float moveFrequency = 1f;           // How quickly it changes direction

    [Header("Rotation Settings")]
    public float rotationSpeed = 30f;          // How fast it can rotate
    public float rotationChangeInterval = 2f;  // How often it randomly changes rotation

    private Vector3 originalPosition;
    private float timeOffset;
    private Vector3 currentRotation;

    void Start()
    {
        originalPosition = transform.position;
        timeOffset = Random.Range(0f, 100f); // Makes multiple objects move differently
        InvokeRepeating(nameof(RandomizeRotation), 0f, rotationChangeInterval);
    }

    void Update()
    {
        // Horizontal oscillation with randomness
        float xOffset = Mathf.Sin((Time.time + timeOffset) * moveFrequency) * moveRange;
        transform.position = originalPosition + new Vector3(xOffset, 0f, 0f);

        // Apply rotation
        transform.Rotate(currentRotation * rotationSpeed * Time.deltaTime);
    }

    void RandomizeRotation()
    {
        currentRotation = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
    }
}
