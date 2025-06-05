using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBildings : MonoBehaviour
{
    [SerializeField] private Bilder _bilder;
    [SerializeField] private IronTimer _ironTimer;
    [SerializeField] private RockTimer _rockTimer;
    [SerializeField] private WoodTimer _woodTimer;
    [SerializeField] private WheatTimer _wheatTimer;
    [SerializeField] private BuyPeasants _peasants;
    
    [SerializeField] private GameObject _arsenal;
    [SerializeField] private GameObject _barracks;
    [SerializeField] private GameObject _warehouse;
    [SerializeField] private GameObject _house;
    [SerializeField] private GameObject _mine;
    [SerializeField] private GameObject _quarry;
    [SerializeField] private GameObject _sawmill;
    [SerializeField] private GameObject _scout;

    [SerializeField] private GameObject _buyArsenal;
    [SerializeField] private GameObject _buyBarracks;
    [SerializeField] private GameObject _buyComposition;
    [SerializeField] private GameObject _buyHouse;
    [SerializeField] private GameObject _buyMine;
    [SerializeField] private GameObject _buyQuarry;    
    [SerializeField] private GameObject _buySawmill;
    [SerializeField] private GameObject _buyScout;

    [SerializeField] private GameObject _descriptionArsenal;
    [SerializeField] private GameObject _descriptionBarracks;
    [SerializeField] private GameObject _descriptionComposition;
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

                _wheatTimer.howManyPeasant -= 6;
                _woodTimer.howManyWood -= 15;
                _rockTimer.howManyRock -= 15;

                _ironTimer.howManyI.text = $"{_ironTimer.howManyIron}";
                _rockTimer.howManyR.text = $"{_rockTimer.howManyRock}";
                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeBarracks)
            {
                _barracks.SetActive(true);
                _buyBarracks.SetActive(false);
                _descriptionBarracks.SetActive(true);
                _bilder.activeBarracks = false;

                _wheatTimer.howManyPeasant -= 3;
                _woodTimer.howManyWood -= 10;
                _wheatTimer.howManyWheat -= 35;

                _ironTimer.howManyI.text = $"{_ironTimer.howManyIron}";
                _rockTimer.howManyR.text = $"{_rockTimer.howManyRock}";
                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeComposition)
            {
                _warehouse.SetActive(true);
                _buyComposition.SetActive(false);
                _descriptionComposition.SetActive(true);
                _bilder.activeComposition = false;

                _wheatTimer.howManyPeasant -= 1;
                _woodTimer.howManyWood -= 10;
                _wheatTimer.howManyWheat -= 20;

                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeHouse)
            {
                _house.SetActive(true);
                _buyHouse.SetActive(false);
                _descriptionHouse.SetActive(true);
                _bilder.activeHouse = false;

                _wheatTimer.howManyPeasant -= 1;
                _woodTimer.howManyWood -= 15;
                _wheatTimer.howManyWheat -= 20;

                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeMine)
            {
                _mine.SetActive(true);
                _buyMine.SetActive(false);
                _descriptionMine.SetActive(true);
                _bilder.activeMine = false;

                _wheatTimer.howManyPeasant -= 4;
                _woodTimer.howManyWood -= 20;
                _rockTimer.howManyRock -= 15;
                _ironTimer.howManyIron -= 5;

                _ironTimer.howManyI.text = $"{_ironTimer.howManyIron}";
                _rockTimer.howManyR.text = $"{_rockTimer.howManyRock}";
                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeQuarry)
            {
                _quarry.SetActive(true);
                _buyQuarry.SetActive(false);
                _descriptionQuarry.SetActive(true);
                _bilder.activeQuarry = false;

                _wheatTimer.howManyPeasant -= 3;
                _woodTimer.howManyWood -= 15;
                _rockTimer.howManyRock -= 5;

                _rockTimer.howManyR.text = $"{_rockTimer.howManyRock}";
                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeSawmill)
            {
                _sawmill.SetActive(true);
                _buySawmill.SetActive(false);
                _descriptionSawmill.SetActive(true);
                _bilder.activeSawmill = false;

                _wheatTimer.howManyWheat -= 25;
                _wheatTimer.howManyPeasant -= 2;
                _woodTimer.howManyWood -= 10;

                _woodTimer.howManyW.text = $"{_woodTimer.howManyWood}";
                _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
            if (_bilder.activeScout)
            {
                _scout.SetActive(true);
                _buyScout.SetActive(false);
                _descriptionScout.SetActive(true);
                _bilder.activeScout = false;

                _wheatTimer.howManyWheat -= 25;
                _wheatTimer.howManyPeasant -= 2;

                _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";
                _peasants.howManyP.text = $"{_wheatTimer.howManyPeasant}";
            }
        }
    }
}
