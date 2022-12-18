using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
    //The call-back of contact trigger
    void OnCollisionEnter(Collision hit)
    {
        //When player contact "DangerWall"
        if (hit.gameObject.CompareTag("Player"))
        {
            //Get scene index
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            //Reload scene
            SceneManager.LoadScene(sceneIndex);
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
