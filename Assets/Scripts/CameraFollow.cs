using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    void Update()
    {
        
            Vector3 newPosition = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z) + offset;

            transform.position = newPosition;
        
       
    }
}
