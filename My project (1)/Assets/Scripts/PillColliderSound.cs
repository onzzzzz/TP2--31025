using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillColliderSound : MonoBehaviour
{
    public AudioSource audioData2;
    
    void Start()
    {
       audioData2 = GetComponent<AudioSource>(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioData2.Play();
            Destroy(gameObject, 1f);
        }
    }
}
