using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadzone : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.LoseLife();
    }
}
