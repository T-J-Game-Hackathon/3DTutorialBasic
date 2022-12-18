using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Controll speed
    public float speed = 10;
    void FixedUpdate()
    {
        //substation 'input into x and z
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //acquire Rogodbpdy component which same Game object owned
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        //add a power to x(side) and z(depth) in rigidbody
        //Multiply x and y by speed
        rigidbody.AddForce(x * speed, 0, z * speed);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
