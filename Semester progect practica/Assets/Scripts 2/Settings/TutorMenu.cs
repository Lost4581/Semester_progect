using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorMenu : MonoBehaviour
{
    [SerializeField] private GameObject _tutorMenu;
    [SerializeField] private List<GameObject> _cells;
    private bool _isActiveCell = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _tutorMenu.SetActive(!_tutorMenu.activeSelf);
            for (int i = 0; i < _cells.Count; i++)
            {
                _cells[i].GetComponent<Collider>().enabled = _isActiveCell;
            }
            _isActiveCell = !_isActiveCell;
        }
    }
}

