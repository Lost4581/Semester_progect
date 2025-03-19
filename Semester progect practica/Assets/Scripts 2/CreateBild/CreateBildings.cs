using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBildings : MonoBehaviour
{
    private Bilder _bilder;
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
        if (_bilder.activeArsenal)
        {
            _arsenal.SetActive(true);
        }
        if (_bilder.activeBarracks)
        {
            _barracks.SetActive(true);
        }
        if (_bilder.activeComposition)
        {
            _composition.SetActive(true);
        }
        if (_bilder.activeFarm)
        {
            _farm.SetActive(true);
        }
        if (_bilder.activeHouse)
        {
            _house.SetActive(true);
        }
        if (_bilder.activeMine)
        {
            _mine.SetActive(true);
        }
        if (_bilder.activeQuarry)
        {
            _quarry.SetActive(true);
        }
        if (_bilder.activeSawmill)
        {
            _sawmill.SetActive(true);
        }
        if (_bilder.activeScout)
        {
            _scout.SetActive(true); 
        }
    }
}
