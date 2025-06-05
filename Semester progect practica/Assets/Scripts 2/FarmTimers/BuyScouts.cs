using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyScouts : MonoBehaviour
{
    [SerializeField] private WheatTimer wheatTimer;
    [SerializeField] private BuyPeasants peasantScript;
    [SerializeField] public TextMeshProUGUI howManyScouts;
    [SerializeField] private int howManyNeedWheat = 15;
    [SerializeField] private int howManyNeedPeasant = 1;

    [SerializeField] private GameObject buyButton;
    [SerializeField] private GameObject buyButtonBG;

    [SerializeField] private float maxScoutCount = 5;

    public float HowManyScouts;

    private void Start()
    {
        howManyScouts.text = $"Исследователи: {HowManyScouts}/5";
    }

    private void Update()
    {
        ChekingForBuyScout();
    }

    private void ChekingForBuyScout()
    {
        if (wheatTimer.howManyWheat >= howManyNeedWheat && wheatTimer.howManyPeasant >= howManyNeedPeasant)
        {
            buyButton.SetActive(true);
            buyButtonBG.SetActive(false);
        }
        else
        {
            buyButton.SetActive(false);
            buyButtonBG.SetActive(true);
        }
    }

    public void BuyScoutsVoid()
    {
        wheatTimer.howManyWheat -= howManyNeedWheat;
        wheatTimer.howManyPeasant -= howManyNeedPeasant;
        HowManyScouts++;
        howManyScouts.text = $"Исследователи: {HowManyScouts}/5";
        peasantScript.howManyP.text = $"{wheatTimer.howManyPeasant}";

        if (HowManyScouts >= maxScoutCount)
        {
            HowManyScouts = maxScoutCount;
            howManyScouts.text = $"Исследователи: {HowManyScouts}/5";
            peasantScript.howManyP.text = $"{wheatTimer.howManyPeasant}";
        }
    }
}
