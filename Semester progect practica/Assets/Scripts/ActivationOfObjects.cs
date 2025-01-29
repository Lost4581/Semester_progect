using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationOfObjects : MonoBehaviour
{
    [SerializeField] GameObject someThing
;
    void OnMouseDown()
    {
        someThing.SetActive(true);
    }
}
