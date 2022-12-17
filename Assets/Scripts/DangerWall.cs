using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerWall : MonoBehaviour
{
  // Start is called before the first frame update
  void Start() { }

  // Update is called once per frame
  void Update() { }

  void OnCollisionEnter(Collision other)
  {
    // If the player collides with the wall...
    if (other.gameObject.CompareTag("Player"))
    {
      // ...then reload the scene to restart the game.
      UnityEngine.SceneManagement.SceneManager.LoadScene(
        UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
      );
    }
  }
}
