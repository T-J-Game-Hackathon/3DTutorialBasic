using UnityEngine;

public class Item : MonoBehaviour
{
  public GameObject player;

  public void Update()
  {
    var direction = transform.position - player.transform.position;
    direction.Normalize();
    transform.position += direction * 0.01f;
  }

  public void OnTriggerEnter(Collider collidedObject)
  {
    if (collidedObject.CompareTag("Player"))
    {
      Destroy(gameObject);
    }
  }
}
