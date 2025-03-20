using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDescription : MonoBehaviour
{
    [SerializeField] private GameObject _descriptionArsenal;
    [SerializeField] private GameObject _descriptionBarracks;
    [SerializeField] private GameObject _descriptionComposition;
    [SerializeField] private GameObject _descriptionFarm;
    [SerializeField] private GameObject _descriptionHouse;
    [SerializeField] private GameObject _descriptionMine;
    [SerializeField] private GameObject _descriptionQuarry;
    [SerializeField] private GameObject _descriptionSawmill;
    [SerializeField] private GameObject _descriptionScout;

    [SerializeField] private GameObject _arsenal;
    [SerializeField] private GameObject _barracks;
    [SerializeField] private GameObject _composition;
    [SerializeField] private GameObject _farm;
    [SerializeField] private GameObject _house;
    [SerializeField] private GameObject _mine;
    [SerializeField] private GameObject _quarry;
    [SerializeField] private GameObject _sawmill;
    [SerializeField] private GameObject _scout;

    private void OnMouseDown()
    {
        if ( _arsenal.activeInHierarchy)
        {
            _descriptionArsenal.SetActive(true);
        }
        if (_barracks.activeInHierarchy)
        {
            _descriptionBarracks.SetActive(true);
        }
        if (_composition.activeInHierarchy)
        {
            _descriptionComposition.SetActive(true);
        }
        if (_farm.activeInHierarchy)
        {
            _descriptionFarm.SetActive(true);
        }
        if (_house.activeInHierarchy)
        {
            _descriptionHouse.SetActive(true);
        }
        if (_mine.activeInHierarchy)
        {
            _descriptionMine.SetActive(true);
        }
        if (_quarry.activeInHierarchy)
        {
            _descriptionQuarry.SetActive(true);
        }
        if (_sawmill.activeInHierarchy)
        {
            _descriptionSawmill.SetActive(true);
        }
        if (_scout.activeInHierarchy)
        {
            _descriptionScout.SetActive(true);
        }
    }
}
