using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectCollison : MonoBehaviour
{
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
       audioData = GetComponent<AudioSource>(); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioData.Play();
            
            Destroy(gameObject, 5f);
            

        }
    }
}
