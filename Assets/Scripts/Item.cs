using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //The call-back of contact trigger
    void OnTriggerEnter(Collider hit)
    {
        //Is the contct target "Player" tag?
        if (hit.CompareTag("Player"))
        {
            //Destroy the GameObject with this component
            Destroy(gameObject);
        }
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
