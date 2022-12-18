using UnityEngine;

public class Player2Controller : MonoBehaviour
{
  public float speed = 10f;
  public float turnSpeed = 10f;

  private Animator animator;
  private Rigidbody rb;

  public void Start()
  {
    animator = GetComponent<Animator>();
    rb = GetComponent<Rigidbody>();
  }

  public void FixedUpdate()
  {
    var x = Input.GetAxis("Horizontal");
    var z = Input.GetAxis("Vertical");

    if (x == 0 && z == 0)
    {
      rb.velocity = new Vector3(0, rb.velocity.y, 0);
      rb.angularVelocity = Vector3.zero;

      animator.SetBool("isWalk", false);
    }
    else
    {
      rb.AddForce(x * speed, 0, z * speed);

      float degree = 90 - (Mathf.Atan2(z, x) * 180 / Mathf.PI);
      Quaternion dest_quat = Quaternion.Euler(0, degree, 0);
      Quaternion curr_quat = transform.rotation;
      transform.rotation = Quaternion.RotateTowards(curr_quat, dest_quat, turnSpeed);

      animator.SetBool("isWalk", true);
    }
  }
}
