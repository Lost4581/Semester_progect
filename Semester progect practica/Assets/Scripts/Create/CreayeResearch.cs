using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreayeResearch : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject research;
    [SerializeField] GameObject BuyResearch;
    [SerializeField] GameObject BuyResearchBG;
    [SerializeField] GameObject WherePutResearch;

    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject home;

    [SerializeField] GameObject mainBuilding1;
    [SerializeField] GameObject mainBuilding2;
    [SerializeField] GameObject mainBuilding3;
    [SerializeField] GameObject mainBuilding4;
    [SerializeField] GameObject mainBuilding5;
    [SerializeField] GameObject mainBuilding6;
    [SerializeField] GameObject mainBuilding7;
    [SerializeField] GameObject mainBuilding8;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false
        && mine.activeInHierarchy == false && warehouse.activeInHierarchy == false && baracks.activeInHierarchy == false && home.activeInHierarchy == false
        && (mainBuilding1.activeInHierarchy == true || mainBuilding2.activeInHierarchy == true || mainBuilding3.activeInHierarchy == true || mainBuilding4.activeInHierarchy == true
        || mainBuilding5.activeInHierarchy == true || mainBuilding6.activeInHierarchy == true || mainBuilding7.activeInHierarchy == true || mainBuilding8.activeInHierarchy == true))
        {
            research.SetActive(true);
            BuyResearch.SetActive(false);
            BuyResearchBG.SetActive(true);
            WherePutResearch.SetActive(false);
        }
    }
}
