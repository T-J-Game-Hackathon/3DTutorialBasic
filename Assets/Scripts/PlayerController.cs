using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void FixedUpdate()
    {
        // Get the horizontal and vertical input.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a vector3 variable, and assign X and Z to feature the horizontal and vertical input.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * moveSpeed;

        // Add a force to the rigidbody's movement vector.
        GetComponent<Rigidbody>()
            .AddForce(movement);
    }
}
