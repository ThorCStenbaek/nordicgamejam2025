using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 200f;

  void Update()
{
    float horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
    float vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

    Vector3 movement = transform.forward * vertical + transform.right * horizontal;
    transform.Translate(movement, Space.World);
}


}
