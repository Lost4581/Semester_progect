using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHome : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject home;
    [SerializeField] GameObject BuyHome;
    [SerializeField] GameObject BuyHomeBG;
    [SerializeField] GameObject WherePutHome;

    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject research;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false
        && mine.activeInHierarchy == false && warehouse.activeInHierarchy == false && baracks.activeInHierarchy == false && research.activeInHierarchy == false)
        {
            home.SetActive(true);
            BuyHome.SetActive(false);
            BuyHomeBG.SetActive(true);
            WherePutHome.SetActive(false);
        }
    }
}
