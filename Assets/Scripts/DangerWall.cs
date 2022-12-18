using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
  public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player")
    {
      var sceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(sceneIndex);
    }
  }
}
