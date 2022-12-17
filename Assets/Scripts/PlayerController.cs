using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
  public Rigidbody Rb;

  public float Speed = 10f;

  public void Start()
  {
    Rb = GetComponent<Rigidbody>();
  }

  public void FixedUpdate()
  {
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * Speed;
    Rb.AddForce(movement);
  }
}
