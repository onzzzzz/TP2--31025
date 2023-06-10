using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    public Transform player;
    public  Vector3 offset;
    public float smoothSpeed = 0.123f;

    void FixedUpdate()
    {
        transform.LookAt(player);
        Vector3 wantedPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, wantedPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
