using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    void Start()
    {
        //calculate the camera offeset from the player
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // then change the position every frame
        transform.position = player.position + offset;
    }
}
