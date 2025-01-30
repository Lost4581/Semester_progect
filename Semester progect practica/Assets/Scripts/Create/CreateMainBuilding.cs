using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMainBuilding : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject mainBuilding;
    [SerializeField] GameObject buyMainBuilding;
    [SerializeField] GameObject wherePutMainBuilding;
    [SerializeField] GameObject buyMainBuildingBG;
    
    [SerializeField] GameObject mill;
    [SerializeField] GameObject sawmill;
    [SerializeField] GameObject mine;
    [SerializeField] GameObject warehouse;
    [SerializeField] GameObject baracks;
    [SerializeField] GameObject home;
    [SerializeField] GameObject research;

    public void OnClick()
    {
        if (foundation.activeInHierarchy && mill.activeInHierarchy == false && sawmill.activeInHierarchy == false && mine.activeInHierarchy == false
            && warehouse.activeInHierarchy == false && baracks.activeInHierarchy == false && home.activeInHierarchy == false && research.activeInHierarchy == false)
        {
            mainBuilding.SetActive(true);
            buyMainBuilding.SetActive(false);
            buyMainBuildingBG.SetActive(true);
            wherePutMainBuilding.SetActive(false);
        }
    }
}
