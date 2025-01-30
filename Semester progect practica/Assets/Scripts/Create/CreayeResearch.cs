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

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mainBuilding.activeInHierarchy == false && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false
        && mine.activeInHierarchy == false && warehouse.activeInHierarchy == false && baracks.activeInHierarchy == false && home.activeInHierarchy == false)
        {
            research.SetActive(true);
            BuyResearch.SetActive(false);
            BuyResearchBG.SetActive(true);
            WherePutResearch.SetActive(false);
        }
    }
}
