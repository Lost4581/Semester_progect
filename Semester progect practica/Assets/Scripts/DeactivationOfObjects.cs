using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivationOfObjects : MonoBehaviour
{
    [SerializeField] GameObject someThing
;
    void OnMouseDown()
    {
        someThing.SetActive(false);
    }
}
