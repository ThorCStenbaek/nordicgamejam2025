using UnityEngine;

public class Rotate : MonoBehaviour
{
    [ContextMenu("Rotate X 180")]
    public void RotateX180()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.x += 180f;
        transform.eulerAngles = currentRotation;
    }

    [ContextMenu("Rotate Y 180")]
    public void RotateY180()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.y += 180f;
        transform.eulerAngles = currentRotation;
    }

    [ContextMenu("Rotate Z 180")]
    public void RotateZ180()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += 180f;
        transform.eulerAngles = currentRotation;
    }

    [ContextMenu("Rotate All Enabled Axes 180")]
    public void Rotate180(bool rotateX = false, bool rotateY = true, bool rotateZ = false)
    {
        Vector3 currentRotation = transform.eulerAngles;

        if (rotateX)
            currentRotation.x += 180f;

        if (rotateY)
            currentRotation.y += 180f;

        if (rotateZ)
            currentRotation.z += 180f;

        transform.eulerAngles = currentRotation;
    }
}
