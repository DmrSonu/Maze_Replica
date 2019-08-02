using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotatingAxis;
    public int rotatingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this make the flatform rotate about its axis
        transform.Rotate(rotatingAxis * Time.deltaTime * rotatingSpeed);
    }
}
