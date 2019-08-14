using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformWheel : MonoBehaviour
{
    [SerializeField] Vector3 rotatingAxis;
    [SerializeField] float wheelSpeed = 0.5f;

    GameObject[] rotatingPosition;
    
    void FixedUpdate()
    {
        transform.Rotate(rotatingAxis * wheelSpeed);
    }
}
