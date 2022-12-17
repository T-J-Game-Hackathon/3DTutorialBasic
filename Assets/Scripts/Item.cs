using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
  // Start is called before the first frame update
  void Start() { }

  // Update is called once per frame
  void Update() { }

  void OnTriggerEnter(Collider other)
  {
    Debug.Log(
      "Item collided with "
        + other.gameObject.name
        + ", tagged with: "
        + other.gameObject.tag
    );
    if (other.gameObject.CompareTag("Player"))
    {
      Debug.Log("Item collected!");
      Destroy(gameObject);
    }
  }
}
