using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWarehouse : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject BuyWarehouse;
    [SerializeField] GameObject BuyWarehouseBG;
    [SerializeField] GameObject WherePutWarehouse;

    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject research;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject home;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false
        && mine.activeInHierarchy == false && research.activeInHierarchy == false && baracks.activeInHierarchy == false && home.activeInHierarchy == false)
        {
            warehouse.SetActive(true);
            BuyWarehouse.SetActive(false);
            BuyWarehouseBG.SetActive(true);
            WherePutWarehouse.SetActive(false);
        }
    }
}
