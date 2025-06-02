using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseStorage : MonoBehaviour
{
    [SerializeField] private WheatTimer _wheatTimer;
    [SerializeField] private WoodTimer _woodTimer;

    [SerializeField] private List<GameObject> AllWarehouse;

    [SerializeField] public int NewLimitWheat;
    [SerializeField] public int NewLimitWood;

    private void Update()
    {
        UpLimits();
    }
    private void UpLimits()
    {
        for (int i = 0; i  < AllWarehouse.Count; i++)
        {
            if (AllWarehouse[i].activeInHierarchy)
            {
                _wheatTimer.maxWheat = NewLimitWheat;
                _woodTimer.maxWood = NewLimitWood;
            }
        }
    }
}
