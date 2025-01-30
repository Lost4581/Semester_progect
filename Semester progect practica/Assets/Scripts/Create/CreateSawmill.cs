using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSawmill : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject BuySawmill;
    [SerializeField] GameObject BuySawmillBG;
    [SerializeField] GameObject WherePutSawmill;

    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject home;
    [SerializeField] GameObject research;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && mine.activeInHierarchy == false
        && baracks.activeInHierarchy == false && warehouse.activeInHierarchy == false && home.activeInHierarchy == false && research.activeInHierarchy == false)
        {
            sawmill.SetActive(true);
            BuySawmill.SetActive(false);
            BuySawmillBG.SetActive(true);
            WherePutSawmill.SetActive(false);
        }
    }  
}
