using UnityEngine;

public class Destroy : MonoBehaviour
{
    [ContextMenu("Destroy Now")]
    public void DestroyNow()
    {
        Destroy(gameObject);
    }
}
