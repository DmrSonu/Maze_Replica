using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformMotion : MonoBehaviour
{
    public Vector3 finalPositon;
    public float speed;

    Vector3 startPosition;
    
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float i;
        startPosition.y= Mathf.Lerp(startPosition.y, finalPositon.y, Mathf.Sin(Time.time * speed)) / 2;
        transform.position = startPosition;
    }
}
