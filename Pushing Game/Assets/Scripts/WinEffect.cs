using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEffect : MonoBehaviour
{
    public ParticleSystem[] particles;

    void Start()
    {
        particles[0].Stop();
        particles[1].Stop();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            particles[0].Play();
        }
        else if (collision.gameObject.CompareTag("Enemy2"))
        {
            particles[1].Play();
        }

    }
}
