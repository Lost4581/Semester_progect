using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnMousClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0 + 1, 0);
        }
    }
}
