using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCircular : MonoBehaviour
{
    private float _angle = 0f;
    private Vector3 rotationCenter;

    [SerializeField]
    public float angularSpeed = 2f;
    [SerializeField]
    public float rotationRadius = 2f;

    void Start()
    {
        rotationCenter = this.transform.position;
    } 
    
    void Update() {
        // Update angle
        _angle += Time.deltaTime * angularSpeed;
        // Calculate direction from center - rotate the up vector Angle degrees clockwise
        var direction = Quaternion.AngleAxis(_angle, Vector3.forward) * Vector3.up;
        // Update position based on center, the direction, and the radius (which is a constant)
        transform.position = rotationCenter + direction * rotationRadius;
    }
}
