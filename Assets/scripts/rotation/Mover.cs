using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveDuration = 1f;
    public Vector3 predefinedTarget;

    private Coroutine moveCoroutine;

    public void MoveTo(Vector3 targetPosition)
    {
        if (moveCoroutine != null)
        {
            StopCoroutine(moveCoroutine);
        }

        moveCoroutine = StartCoroutine(MoveOverTime(targetPosition));
    }

    public void MoveToPredefinedTarget()
    {
        MoveTo(predefinedTarget);
    }

    private System.Collections.IEnumerator MoveOverTime(Vector3 targetPosition)
    {
        Vector3 startPos = transform.position;
        float elapsed = 0f;

        while (elapsed < moveDuration)
        {
            transform.position = Vector3.Lerp(startPos, targetPosition, elapsed / moveDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
    }
}
