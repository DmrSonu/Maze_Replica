using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantWheel : MonoBehaviour
{
    [SerializeField] GameObject plateformPrefab;

    GameObject plateform;

    // Start is called before the first frame update
    public void Start()
    {
        plateform = Instantiate(plateformPrefab, transform.position, Quaternion.Euler(0, 30, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        plateform.transform.position = transform.position;
    }
}
