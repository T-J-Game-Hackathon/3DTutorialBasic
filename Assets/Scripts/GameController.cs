using UnityEngine;

public class GameController : MonoBehaviour
{
  public UnityEngine.UI.Text scoreLabel;

  public void Update()
  {
    var item = GameObject.Find("Item");
    scoreLabel.text = item.GetComponent<Item>().collidCount.ToString();
  }
}
