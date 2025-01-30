using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBarracks : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject BuyBaracks;
    [SerializeField] GameObject BuyBaracksBG;
    [SerializeField] GameObject WherePutBaracks;

    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject home;
    [SerializeField] GameObject research;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false
        && mine.activeInHierarchy == false && warehouse.activeInHierarchy == false && home.activeInHierarchy == false && research.activeInHierarchy == false)
        {
            baracks.SetActive(true);
            BuyBaracks.SetActive(false);
            BuyBaracksBG.SetActive(true);
            WherePutBaracks.SetActive(false);
        }
    } 
}
