using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCntroller : MonoBehaviour
{
    public int jumpHeight;
    public float speed;
    public Transform feet;
    public float feetRadius;
    public LayerMask groundType;
    private Rigidbody rb;

    bool isGrounded;
    float xAsix;
    float zAsix;
    Rigidbody body;
    Vector3 movement;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //takes player phone accelerometer input and feed in the variable
        xAsix = Input.acceleration.x * Time.deltaTime * speed;
        zAsix = Input.acceleration.y * Time.deltaTime * speed;

        movement.Set(xAsix, 0, zAsix);

        transform.Translate(movement); 
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(feet.position, feetRadius, groundType);

        if(Input.touchCount > 0 && isGrounded)
        {
            body.velocity = Vector3.up * jumpHeight;
            Debug.Log(Input.touchCount);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //whenever the ball collide with the coin its destroy
        //overhere you can add the score system
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
