using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageHome : MonoBehaviour
{
    [SerializeField] private WheatTimer _wheatTimer;

    [SerializeField] private List<GameObject> Allhouse;

    [SerializeField] private int NewLimitPeasant;

    private void Update()
    {
        UpLimits();
    }

    private void UpLimits()
    {
        for (int i = 0; i  < Allhouse.Count; i++)
        {
            if (Allhouse[i].activeInHierarchy)
            {
                _wheatTimer.maxPeasant = NewLimitPeasant;
            }
        }
    }
}
