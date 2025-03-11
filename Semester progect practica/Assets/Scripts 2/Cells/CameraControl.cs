using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private List<GameObject> cameras;
    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _button;
    [SerializeField] private bool _isActive = false;
    
    public void OnMouseDown()
    {
        _button.SetActive(_isActive);
        _camera.SetActive(true);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
    }
}
