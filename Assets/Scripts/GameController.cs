using UnityEngine;

public class GameController : MonoBehaviour
{
  public UnityEngine.UI.Text scoreLabel;
  public GameObject winnerLabelObject;
  public int finishCount = 10;

  public void Update()
  {
    var item = GameObject.Find("Item");
    var count = item.GetComponent<Item>().collidCount;
    scoreLabel.text = count.ToString();

    if (count == finishCount)
    {
      winnerLabelObject.SetActive(true);
    }
  }
}
