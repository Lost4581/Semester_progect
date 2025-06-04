using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDescription : MonoBehaviour
{
    [SerializeField] private GameObject _descriptionArsenal;
    [SerializeField] private GameObject _descriptionBarracks;
    [SerializeField] private GameObject _descriptionWarehouse;
    [SerializeField] private GameObject _descriptionHouse;
    [SerializeField] private GameObject _descriptionMine;
    [SerializeField] private GameObject _descriptionQuarry;
    [SerializeField] private GameObject _descriptionSawmill;
    [SerializeField] private GameObject _descriptionScout;

    [SerializeField] private List<GameObject> _arsenal;
    [SerializeField] private List<GameObject> _barracks;
    [SerializeField] private List<GameObject> _warehouse;
    [SerializeField] private List<GameObject> _house;
    [SerializeField] private List<GameObject> _mine;
    [SerializeField] private List<GameObject> _quarry;
    [SerializeField] private List<GameObject> _sawmill;
    [SerializeField] private List<GameObject> _scout;

    private void OnMouseDown()
    {
        for (int i = 0; i < _arsenal.Count; i++)
        {
            if (_arsenal[i].activeInHierarchy)
            {
                _descriptionArsenal.SetActive(true);
            }
        }

        for (int i = 0; i < _barracks.Count; i++)
        {
            if (_barracks[i].activeInHierarchy)
            {
                _descriptionBarracks.SetActive(true);
            }
        }
        
        for (int i = 0; i < _warehouse.Count; i++)
        {
            if (_warehouse[i].activeInHierarchy)
            {
                _descriptionWarehouse.SetActive(true);
            }
        }

        for (int i = 0; i < _house.Count; i++)
        {
            if (_house[i].activeInHierarchy)
            {
                _descriptionHouse.SetActive(true);
            }
        }
        
        for (int i = 0; i < _mine.Count; i++)
        {
            if (_mine[i].activeInHierarchy)
            {
                _descriptionMine.SetActive(true);
            }
        }
        
        for (int i = 0; i < _quarry.Count; i++)
        {
            if (_quarry[i].activeInHierarchy)
            {
                _descriptionQuarry.SetActive(true);
            }
        }
        
        for (int i = 0; i < _sawmill.Count; i++)
        {
            if (_sawmill[i].activeInHierarchy)
            {
                _descriptionSawmill.SetActive(true);
            }
        }
        
        for (int i = 0; i < _scout.Count; i++)
        {
            if (_scout[i].activeInHierarchy)
            {
                _descriptionScout.SetActive(true);
            }
        }
        
    }
}
