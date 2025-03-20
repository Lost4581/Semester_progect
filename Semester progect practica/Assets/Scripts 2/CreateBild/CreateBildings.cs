using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBildings : MonoBehaviour
{
    [SerializeField] private Bilder _bilder;

    [SerializeField] private GameObject _arsenal;
    [SerializeField] private GameObject _barracks;
    [SerializeField] private GameObject _composition;
    [SerializeField] private GameObject _farm;    
    [SerializeField] private GameObject _house;
    [SerializeField] private GameObject _mine;
    [SerializeField] private GameObject _quarry;
    [SerializeField] private GameObject _sawmill;
    [SerializeField] private GameObject _scout;

    [SerializeField] private GameObject _buyArsenal;
    [SerializeField] private GameObject _buyBarracks;
    [SerializeField] private GameObject _buyComposition;
    [SerializeField] private GameObject _buyFarm;
    [SerializeField] private GameObject _buyHouse;
    [SerializeField] private GameObject _buyMine;
    [SerializeField] private GameObject _buyQuarry;    
    [SerializeField] private GameObject _buySawmill;
    [SerializeField] private GameObject _buyScout;

    [SerializeField] private GameObject _descriptionArsenal;
    [SerializeField] private GameObject _descriptionBarracks;
    [SerializeField] private GameObject _descriptionComposition;
    [SerializeField] private GameObject _descriptionFarm;
    [SerializeField] private GameObject _descriptionHouse;
    [SerializeField] private GameObject _descriptionMine;
    [SerializeField] private GameObject _descriptionQuarry;
    [SerializeField] private GameObject _descriptionSawmill;
    [SerializeField] private GameObject _descriptionScout;

    private void OnMouseDown()
    {
        bool isEmpty = true;
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeInHierarchy)
            {
                isEmpty = false;
                break;
            }
        }
        if (isEmpty)
        {
            if (_bilder.activeArsenal)
            {
                _arsenal.SetActive(true);
                _buyArsenal.SetActive(false);
                _descriptionArsenal.SetActive(true);
                _bilder.activeArsenal = false;
            }
            if (_bilder.activeBarracks)
            {
                _barracks.SetActive(true);
                _buyBarracks.SetActive(false);
                _descriptionBarracks.SetActive(true);
                _bilder.activeBarracks = false;
            }
            if (_bilder.activeComposition)
            {
                _composition.SetActive(true);
                _buyComposition.SetActive(false);
                _descriptionComposition.SetActive(true);
                _bilder.activeComposition = false;
            }
            if (_bilder.activeFarm)
            {
                _farm.SetActive(true);
                _buyFarm.SetActive(false);
                _descriptionFarm.SetActive(true);
                _bilder.activeFarm = false;
            }
            if (_bilder.activeHouse)
            {
                _house.SetActive(true);
                _buyHouse.SetActive(false);
                _descriptionHouse.SetActive(true);
                _bilder.activeHouse = false;
            }
            if (_bilder.activeMine)
            {
                _mine.SetActive(true);
                _buyMine.SetActive(false);
                _descriptionMine.SetActive(true);
                _bilder.activeMine = false;
            }
            if (_bilder.activeQuarry)
            {
                _quarry.SetActive(true);
                _buyQuarry.SetActive(false);
                _descriptionQuarry.SetActive(true);
                _bilder.activeQuarry = false;
            }
            if (_bilder.activeSawmill)
            {
                _sawmill.SetActive(true);
                _buySawmill.SetActive(false);
                _descriptionSawmill.SetActive(true);
                _bilder.activeSawmill = false;
            }
            if (_bilder.activeScout)
            {
                _scout.SetActive(true);
                _buyScout.SetActive(false);
                _descriptionScout.SetActive(true);
                _bilder.activeScout = false;
            }
        }
    }
}
