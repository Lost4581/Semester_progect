using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilder : MonoBehaviour
{
    private BuyManager _currentSelection;

    private void Update()
    {
        CreateBilding();
    }
    public void SetCurrentSelection(BuyManager cell)
    {
        _currentSelection = cell;
    }
    private void CreateBilding()
    {
        if (_currentSelection != null)
        {
            Debug.Log("1565yae");
        }
    }
}
