using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    /// public-variables are accessable from the inspector in the Unity-Editor,
    /// from other classes and the class itself.

    // paddleSpeed stores the value for how fast the paddle moves.
    public float paddleSpeed = 1f;

    /// Writing private is optional as they are private by default, 
    /// just makes it more clear.

    /// Vector3(x, y, z) = a vector in space with x-y-z-coordinates

    // playerPos stores the value for the next player position.
    private Vector3 playerPos = new Vector3(0, -9.5f, 0);

    // NOTE: Yes methods are written with a capital letter in front according to Unity's coding patterns.

    // Update is called once per frame
    void Update()
    {
        /// Input.GetAxis("Horizontal") = Input from the LEFT or RIGHT arrow keys
        /// or from the "A" or "D" keys

        /// transform.position.x returns the x-value for the paddles position
        /// of it's transform component.
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        /// Mathf.Clamp(x, min, max) = the value x is always between the min and 
        /// max values.

        /// playerPos get's updated here to the new calculated position, with
        /// x changing with user input, y and z staying always the same.
        playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9.5f, 0f);
        /// Set the current paddle position = transform.position to the
        /// new position = playerPos.
        transform.position = playerPos;
    }
}
