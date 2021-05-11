using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(CharacterController))]
public class WasdMovement : MonoBehaviour
{
    private CharacterController _controller;
    
    [SerializeField]
    public float speed = 10;
 
    public void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    public void Update()
    {
        var move = new Vector3(
            Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,
            0,
            Input.GetAxisRaw("Vertical") * speed * Time.deltaTime
        );
        move = transform.TransformDirection(move);
        _controller.Move(move * speed);
    }
}
