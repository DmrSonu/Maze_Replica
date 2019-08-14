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
    public Vector3 boostForce;

    public LayerMask boost;

    bool isGrounded;
    float xAsix;
    float zAsix;
    Rigidbody body;
    Vector3 movement;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        xAsix = Input.acceleration.x;
        zAsix = Input.acceleration.y;

        movement.Set(xAsix * Time.deltaTime * speed, body.velocity.y, zAsix * Time.deltaTime * speed);

        //transform.Translate(movement);

        body.velocity = movement;
        //Debug.Log(body.velocity.magnitude);
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
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Boost"))
        {
            Debug.Log("boost actived");
            body.AddForce(boostForce);
        }
    }
}
