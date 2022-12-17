using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public TMPro.TMP_Text scoreLabel;

  [SerializeField]
  int score = 0;

  // Start is called before the first frame update
  void Start()
  {
    UpdateScore();
  }

  // Update is called once per frame
  void Update() { }

  public void UpdateScore()
  {
    score = GameObject.FindGameObjectsWithTag("Item").Length;
    Debug.Log("Score: " + score);
    scoreLabel.GetComponent<TMPro.TMP_Text>().text = score.ToString();
  }
}
