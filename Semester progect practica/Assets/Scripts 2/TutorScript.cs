using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorScript : MonoBehaviour
{
    [SerializeField] private GameObject image1;

    private bool _canActive = true;

    public void ActivationImage()
    {
        if (_canActive)
        {
            image1.SetActive(true);
            _canActive = false;
        }
    }
}
