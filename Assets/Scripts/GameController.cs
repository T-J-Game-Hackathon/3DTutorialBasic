using UnityEngine;

public class GameController : MonoBehaviour
{
  public UnityEngine.UI.Text scoreLabel;

  public void Update()
  {
    var count = GameObject.FindGameObjectsWithTag("Item").Length;
    scoreLabel.text = count.ToString();
  }
}
