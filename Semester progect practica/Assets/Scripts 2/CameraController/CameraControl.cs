using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private List<GameObject> cameras;
    [SerializeField] private List<GameObject> cells;
    [SerializeField] private List<GameObject> descriptions;
    [SerializeField] private GameObject _camera;
    [SerializeField] private GameObject _button;
    [SerializeField] private bool _isActiveButton = false;
    [SerializeField] private bool _isActiveCell = false;

    public void OnMouseDown()
    {
        _button.SetActive(_isActiveButton);
        _camera.SetActive(true);
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].SetActive(false);
        }
        for (int i = 0; i < cells.Count; i++)
        {
            cells[i].GetComponent<Collider>().enabled = _isActiveCell;
        }
        for (int i = 0; i < descriptions.Count; i++)
        {
            descriptions[i].SetActive(false);
        }
    }
}
