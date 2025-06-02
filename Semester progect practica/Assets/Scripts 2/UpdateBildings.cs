using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBildings : MonoBehaviour
{
    [SerializeField] private WheatTimer wheatTimer;
    [SerializeField] private IronTimer ironTimer;
    [SerializeField] private RockTimer rockTimer;
    [SerializeField] private WoodTimer woodTimer;
    [SerializeField] private BuyPeasants peasantsScript;
    [SerializeField] private WarehouseStorage warehouseScript;

    [SerializeField] private GameObject bildingLVL1;
    [SerializeField] private GameObject bildingLVL2;

    [SerializeField] private GameObject buyButton;
    [SerializeField] private GameObject buyButtonBG;

    [SerializeField] private int newWheatCout = 2;
    [SerializeField] private int newIronCout = 2;
    [SerializeField] private int newRockCout = 2;
    [SerializeField] private int newWoodCout = 2;

    [SerializeField] private int newWheatLimit = 50;
    [SerializeField] private int newWoodLimit = 50;

    [SerializeField] private int howManyNeedWheat;
    [SerializeField] private int howManyNeedIron;
    [SerializeField] private int howManyNeedRock;
    [SerializeField] private int howManyNeedWood;
    [SerializeField] private int howManyNeedPeasant;

    private bool _canUpdating = false;

    private void Update()
    {
        ChecingResourses();
    }

    public void UpdateBilding()
    {
        if (_canUpdating)
        {
            wheatTimer.howManyWheat -= howManyNeedWheat;
            wheatTimer.howManyW.text = $"{wheatTimer.howManyWheat}";

            ironTimer.howManyIron -= howManyNeedIron;
            ironTimer.howManyI.text = $"{ironTimer.howManyIron}";

            rockTimer.howManyRock -= howManyNeedRock;
            rockTimer.howManyR.text = $"{rockTimer.howManyRock}";

            woodTimer.howManyWood -= howManyNeedWood;
            woodTimer.howManyW.text = $"{woodTimer.howManyWood}";

            wheatTimer.howManyPeasant -= howManyNeedPeasant;
            peasantsScript.howManyP.text = $"{wheatTimer.howManyPeasant}";

            bildingLVL1.SetActive(false);
            bildingLVL2.SetActive(true);

            wheatTimer.howManyAddWheat = newWheatCout;
            ironTimer.howManyAddIron = newIronCout;
            rockTimer.howManyAddRock = newRockCout;
            woodTimer.howManyAddWood = newWoodCout;

            warehouseScript.NewLimitWheat = newWheatLimit;
            warehouseScript.NewLimitWood = newWoodLimit;
        }
    }

    private void ChecingResourses()
    {
        if (wheatTimer.howManyWheat == howManyNeedWheat &&
            ironTimer.howManyIron == howManyNeedIron &&
            rockTimer.howManyRock == howManyNeedRock &&
            woodTimer.howManyWood == howManyNeedWood &&
            wheatTimer.howManyPeasant == howManyNeedPeasant)
        {
            _canUpdating = true;
            buyButton.SetActive(true);
        }
        else
        {
            _canUpdating = false;
            buyButton.SetActive(false);
        }
    }
}
