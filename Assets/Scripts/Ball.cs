using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballInitalVelocity = 600f;

    private Rigidbody rb;
    private bool ballInPlay = false;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && ballInPlay == false)
        {
            ballInPlay = true;
            transform.parent = null;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitalVelocity, ballInitalVelocity, 0f));
        }
    }
}
