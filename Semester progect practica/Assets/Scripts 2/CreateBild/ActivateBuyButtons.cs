using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBuyButtons : MonoBehaviour
{
    [SerializeField] private IronTimer _ironTimer;
    [SerializeField] private RockTimer _rockTimer;
    [SerializeField] private WheatTimer _wheatTimer;
    [SerializeField] private WoodTimer _woodTimer;

    [SerializeField] private float HowManyNeedIron;
    [SerializeField] private float HowManyNeedRock;
    [SerializeField] public int HowManyNeedWheat;
    [SerializeField] private float HowManyNeedWood;
    [SerializeField] private float HowManyNeedPeasant;

    [SerializeField] private GameObject AtiveButton;
    [SerializeField] private GameObject DeativeButton;

    private void Update()
    {
        AtivateButtons();
    }

    private void AtivateButtons()
    {
        if (_ironTimer.howManyIron >= HowManyNeedIron &&
            _rockTimer.howManyRock >= HowManyNeedRock &&
            _wheatTimer.howManyWheat >= HowManyNeedWheat && 
            _woodTimer.howManyWood >= HowManyNeedWood &&
            _wheatTimer.howManyPeasant >= HowManyNeedPeasant)
        {
            DeativeButton.SetActive(false);
            AtiveButton.SetActive(true);
        }
        else
        {
            DeativeButton.SetActive(true);
            AtiveButton.SetActive(false);
        }
    }
}
