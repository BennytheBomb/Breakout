using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Ball velocity when the ball get's launched.
    public float ballInitalVelocity = 600f;

    // Rigidbody component of the ball.
    private Rigidbody rb;
    // Is the ball currently in action?
    private bool ballInPlay = false;

    // Awake get's called even before Start()
    void Awake()
    {
        // Get's the Rigidbody component from the Ball GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /// Input.GetButtonDown("Fire1") = Fire button get's pressed down 
        /// (here left mouse button)

        // Ball should only get fired when paddle get's reset
        if (Input.GetButtonDown("Jump") && ballInPlay == false)
        {
            /// Make the ball independent from the paddle, so the ball position
            /// doesn't change when the paddle position changes
            transform.parent = null;
            // Ball is now in action.
            ballInPlay = true;
            /// Usally when working with physics values you would use 
            /// FixedUpdate (get's called in a fixed update loop, 
            /// with same time difference), but here it only get's called once

            /// Ball physics can now be affected by other collision objects.
            /// Be careful with isKinematic, as you have to think the other way
            /// around. So isKinematic = true => Ball get's controlled by script,
            /// isKinematic = false => Ball get's affected (and controlled) by physics.
            rb.isKinematic = false;
            // Vector can be a point, but also a direction, that we use here

            /// Adds a directional force to the ball. The direction is diagonally
            /// as we add force to the x and y direction.
            rb.AddForce(new Vector3(ballInitalVelocity, ballInitalVelocity, 0f));
        }
    }
}
