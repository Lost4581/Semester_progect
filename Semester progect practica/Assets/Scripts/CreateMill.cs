using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMill : MonoBehaviour
{
    [SerializeField] GameObject foundation;
    [SerializeField] GameObject mill;
    [SerializeField] GameObject BuyFarmPanel;

    private void Update()
    {
        OnButtonClick();
    }

    private void OnButtonClick()
    {
        if (foundation.activeInHierarchy == true)
        {
            mill.SetActive(true);
            BuyFarmPanel.SetActive(false);
        }
    }
}
