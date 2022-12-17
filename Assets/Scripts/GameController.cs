using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public TMPro.TMP_Text scoreLabel;
  public GameObject winnerUI;

  [SerializeField]
  int score = 0;

  // Start is called before the first frame update
  void Start()
  {
    winnerUI.SetActive(false);
    UpdateScore();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey("escape"))
      Application.Quit();

    UpdateScore();
  }

  public void UpdateScore()
  {
    score = GameObject.FindGameObjectsWithTag("Item").Length;
    Debug.Log("Score: " + score);
    scoreLabel.GetComponent<TMPro.TMP_Text>().text = score.ToString();

    if (score == 0)
      GameClear();
  }

  public void GameClear()
  {
    // Make winner UI visible
    winnerUI.SetActive(true);
  }
}
