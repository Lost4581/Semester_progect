using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMill : MonoBehaviour
{
    [SerializeField] GameObject foundation;

    [SerializeField] GameObject mill;
    [SerializeField] GameObject BuyFarm;
    [SerializeField] GameObject WherePutFarm;
    [SerializeField] GameObject BuyFarmBG;
    
    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject home;
    [SerializeField] GameObject research;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && sawmill.activeInHierarchy == false && mine.activeInHierarchy == false
            && warehouse.activeInHierarchy == false && baracks.activeInHierarchy == false && home.activeInHierarchy == false && research.activeInHierarchy == false)
        {
            mill.SetActive(true);
            BuyFarm.SetActive(false);
            BuyFarmBG.SetActive(true);
            WherePutFarm.SetActive(false);
        }
    }
}
