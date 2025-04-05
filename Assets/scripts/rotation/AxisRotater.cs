using UnityEngine;
using System.Collections;

public class AxisRotator : MonoBehaviour
{
    public enum RotationAxis { X, Y, Z }

    [Header("Rotation Settings")]
    public RotationAxis axis = RotationAxis.X;
    public float rotationDuration = 1f; // Time in seconds

    [Header("Open/Closed Angles")]
    public float closedAngle = 0f;
    public float openAngle = 90f;

    private bool isOpen = false;
    private Coroutine rotationRoutine;

    public void Toggle()
    {
        if (rotationRoutine != null)
            StopCoroutine(rotationRoutine);

        float start = GetCurrentAxisAngle();
        float end = isOpen ? closedAngle : openAngle;
        rotationRoutine = StartCoroutine(RotateOverTime(start, end));
        isOpen = !isOpen;
    }

private IEnumerator RotateOverTime(float startAngle, float endAngle)
{
    float elapsed = 0f;

    while (elapsed < rotationDuration)
    {
        elapsed += Time.deltaTime;
        float t = Mathf.Clamp01(elapsed / rotationDuration);
        float currentAngle = Mathf.LerpAngle(startAngle, endAngle, t);

        ApplyRotation(currentAngle);
        yield return null;
    }

    ApplyRotation(endAngle);
    rotationRoutine = null;
}


    private void ApplyRotation(float angle)
    {
        Vector3 currentRotation = transform.eulerAngles;

        switch (axis)
        {
            case RotationAxis.X:
                transform.eulerAngles = new Vector3(angle, currentRotation.y, currentRotation.z);
                break;
            case RotationAxis.Y:
                transform.eulerAngles = new Vector3(currentRotation.x, angle, currentRotation.z);
                break;
            case RotationAxis.Z:
                transform.eulerAngles = new Vector3(currentRotation.x, currentRotation.y, angle);
                break;
        }
    }

    private float GetCurrentAxisAngle()
    {
        Vector3 currentRotation = transform.eulerAngles;

        return axis switch
        {
            RotationAxis.X => currentRotation.x,
            RotationAxis.Y => currentRotation.y,
            RotationAxis.Z => currentRotation.z,
            _ => 0f
        };
    }
}
