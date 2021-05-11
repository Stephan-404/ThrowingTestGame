using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem onDestroyParticles;
    
    private void OnCollisionEnter(Collision other)
    {
        onDestroyParticles.Play();
        Destroy(gameObject);
    }
}
