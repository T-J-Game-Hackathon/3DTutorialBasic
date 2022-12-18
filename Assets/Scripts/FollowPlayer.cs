using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject target; //Reference to target
    private Vector3 offset; //relative distance
    // Start is called before the first frame update
    void Start()
    {
        //Get relative distance between "Player" and "Main Camera"
        offset = GetComponent<Transform>().position - target.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //set "Player's position + relative distance"  to oneself
        GetComponent<Transform>().position = target.transform.position + offset;
        
    }
}
