using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformWheel : MonoBehaviour
{
    [SerializeField] Vector3 rotatingAxis;
    [SerializeField] float wheelSpeed;
    //erializeField] Transform[] wheelPoint;
    //rializeField] GameObject floatingPlatformPrefab;

    GameObject[] rotatingPosition;

    public void Start()
    {
        //eelPlateformInstantiate();
    }

  //public void WheelPlateformInstantiate()
  //{
    //  for (int i = 0; i < wheelPoint.Length; i++)
      //{
        //  rotatingPosition = new GameObject[wheelPoint.Length];

    //      rotatingPosition[i] = Instantiate(floatingPlatformPrefab, wheelPoint[i].position, Quaternion.identity) as GameObject;
   //   }
 // }

    private void Update()
    {
        //tatingPosition[0].transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotatingAxis * wheelSpeed);
    }
}
