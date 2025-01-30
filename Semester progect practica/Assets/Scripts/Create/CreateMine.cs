using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMine : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject BuyMine;
    [SerializeField] GameObject BuyMineBG;
    [SerializeField] GameObject WherePutMine;

    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject home;
    [SerializeField] GameObject research;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false
        && baracks.activeInHierarchy == false && warehouse.activeInHierarchy == false && home.activeInHierarchy == false && research.activeInHierarchy == false)
        {
            mine.SetActive(true);
            BuyMine.SetActive(false);
            BuyMineBG.SetActive(true);
            WherePutMine.SetActive(false);
        }
    }  
}
