using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class MouseFollow : MonoBehaviour
{
  
  private Vector3 _angles;
  public float sensitivityX;
  public float sensitivityY;
  
  void Update()
  {
    var rotationY = Input.GetAxis("Mouse Y")*sensitivityX;
    var rotationX = Input.GetAxis("Mouse X")*sensitivityY;
    if(rotationY>0)
      _angles = new Vector3(Mathf.MoveTowards(_angles.x, -80, rotationY), _angles.y + rotationX, 0);
    else
      _angles = new Vector3(Mathf.MoveTowards(_angles.x, 80, -rotationY), _angles.y + rotationX, 0);
    transform.localEulerAngles = _angles;
  }
}
