using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyPeasants : MonoBehaviour
{
    [SerializeField] private WheatTimer _wheatTimer;
    [SerializeField] private int HowManyNeedWheat = 15;
    [SerializeField] public TextMeshProUGUI howManyP;

    private void Start()
    {
        howManyP.text = $"{_wheatTimer.howManyPeasant}";
    }
    public void BuyPeasant()
    {
        _wheatTimer.howManyPeasant += 1;
        _wheatTimer.howManyWheat -= HowManyNeedWheat;
        howManyP.text = $"{_wheatTimer.howManyPeasant}";
        _wheatTimer.howManyW.text = $"{_wheatTimer.howManyWheat}";

        if (_wheatTimer.howManyPeasant > _wheatTimer.maxPeasant)
        {
            _wheatTimer.howManyPeasant = _wheatTimer.maxPeasant;
            howManyP.text = $"{_wheatTimer.howManyPeasant}";
        }
    }
}
