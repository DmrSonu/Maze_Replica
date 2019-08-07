using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformWheel : MonoBehaviour
{
    [SerializeField] Vector3 rotatingAxis;
    [SerializeField] int wheelSpeed;
    [SerializeField] Transform[] wheelPoint;
    [SerializeField] GameObject floatingPlatformPrefab;

    GameObject[] rotatingPosition;

    private void Start()
    {
        for(int i = 0; i < wheelPoint.Length; i++)
        {
            Debug.Log("ahfa");
            rotatingPosition[i] = Instantiate(floatingPlatformPrefab) as GameObject;
            //rotatingPosition[i].transform.position = wheelPoint[i].position;
            Debug.Log("ahfa");
        }
        /*
        for (int i = 0; i < wheelPoint.Length; i++)
        {
            Instantiate(floatingPlatformPrefab).transform.position = wheelPoint[i].position;
        }*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotatingAxis * wheelSpeed);
    }
}
