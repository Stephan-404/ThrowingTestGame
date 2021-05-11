using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
  [SerializeField]
  public GameObject throwable;

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      var newObject = Instantiate(throwable, transform.position, transform.rotation);
      newObject.GetComponent<Rigidbody>().AddRelativeForce(0, 0, 5000);
    }
  }
}
