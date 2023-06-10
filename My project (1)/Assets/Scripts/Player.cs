using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Walk
    public float speed;
    private Rigidbody _rigidBody;
    //Jump
    public float height;
    private bool isOnFloor = true;
    
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        speed = 8.0f;
        height = 3.0f;
    }

    void FixedUpdate()
    {
        //Walk
        float horizontalValue = Input.GetAxisRaw("Horizontal");
        float verticalValue = Input.GetAxisRaw("Vertical");

        _rigidBody.AddForce(Vector3.forward * speed * verticalValue);
        _rigidBody.AddForce(Vector3.right * speed * horizontalValue);
    
        //Jump
        if (isOnFloor && Input.GetButton("Jump"))
        {
            isOnFloor = false;
            _rigidBody.AddForce(Vector3.up * height, ForceMode.Impulse);
        }
    }

    
    private void OnCollisionEnter(Collision other) 
    {
        isOnFloor = true;
    }
}
