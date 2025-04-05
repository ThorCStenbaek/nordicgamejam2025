using UnityEngine;

public class TurnGreen : MonoBehaviour
{
    public void MakeGreen()
    {
        if (TryGetComponent<Renderer>(out var renderer))
        {
            renderer.material.color = Color.green;
                     Debug.LogWarning($"{gameObject.name} turn green!");
        }
        else
        {
            Debug.LogWarning($"{gameObject.name} has no Renderer to turn green!");
        }
    }

    public void Invoke(){
        MakeGreen();
    }
}
