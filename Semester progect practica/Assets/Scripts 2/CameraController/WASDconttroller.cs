using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDconttroller : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        WASD();
    }
    private void WASD()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.W))
        {
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir += Vector3.back;
        }

        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
