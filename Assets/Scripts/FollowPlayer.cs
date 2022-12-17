using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public GameObject target;

  [SerializeField]
  private Vector3 offset;

  // Start is called before the first frame update
  void Start()
  {
    offset = GetComponent<Transform>().position - target.transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    // 自身の位置をtargetの位置に設定
    GetComponent<Transform>().position = target.transform.position + offset;
  }
}
