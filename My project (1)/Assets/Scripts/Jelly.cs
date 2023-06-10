using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jelly : MonoBehaviour
{

    public static event Action OnCollided;
    
    void Update()
    {
        transform.localRotation = Quaternion.Euler(50f, Time.time * 100f, 20);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollided?.Invoke();
            Destroy(gameObject);
        }
    }
}
