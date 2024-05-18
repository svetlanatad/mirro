using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCameraFollowAlso : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    void Update()
    {

        Vector3 newPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z) + offset;

        transform.position = newPosition;


    }
}
