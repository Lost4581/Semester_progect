using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMill : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject mill;

    private void Update()
    {
        
    }

    private void OnButtoClicked()
    {
        if (foundation.activeInHierarchy == true)
        {
            mill.SetActive(true);
        }
    }
}
