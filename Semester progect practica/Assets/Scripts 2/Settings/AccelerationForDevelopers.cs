using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationForDevelopers : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.O))
        {
            Time.timeScale = 15;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
