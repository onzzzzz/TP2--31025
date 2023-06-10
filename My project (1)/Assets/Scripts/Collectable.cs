using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectable : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;
    public static int count;
    
    void Awake() 
    {  
        total ++;
    }


    void Update()
    {
        transform.localRotation = Quaternion.Euler(110f, Time.time * 100f, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
