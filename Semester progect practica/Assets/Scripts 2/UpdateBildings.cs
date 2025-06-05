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
    [SerializeField] private StorageHome storageHome;

    [SerializeField] private ActivateFarmDescription activateFarmDescription;

    [SerializeField] private GameObject previousLVL;
    [SerializeField] private GameObject nextLVL;

    [SerializeField] private GameObject buyButton;
    [SerializeField] private GameObject buyButtonBG;

    [SerializeField] private int addWheatForCout;
    [SerializeField] private int addIronForCout;
    [SerializeField] private int addRockForCout;
    [SerializeField] private int addWoodForCout;

    [SerializeField] private int addForLimitRock = 5;
    [SerializeField] private int addForLimitIron = 5;
    [SerializeField] private int addForLimitWheat = 5;
    [SerializeField] private int addForLimitWood = 5;
    [SerializeField] private int addForLimitPeasant = 5;

    [SerializeField] private int addForMaxTimeRock = -1;
    [SerializeField] private int addForMaxTimeIron = -1;
    [SerializeField] private int addForMaxTimeWheat = -1;
    [SerializeField] private int addForMaxTimeWood = -1;

    [SerializeField] private int howManyNeedWheat;
    [SerializeField] private int howManyNeedIron;
    [SerializeField] private int howManyNeedRock;
    [SerializeField] private int howManyNeedWood;
    [SerializeField] private int howManyNeedPeasant;

    private bool _canUpdating = false;
    private bool _canChecking = true;

    private void Update()
    {
        ChecingResourses();
    }

    public void UpdateBilding()
    {
        if (_canUpdating && previousLVL.activeInHierarchy)
        {
            _canChecking = false;

            previousLVL.SetActive(false);
            nextLVL.SetActive(true);

            buyButtonBG.SetActive(false);
            buyButton.SetActive(false);

            wheatTimer.howManyAddWheat += addWheatForCout;
            ironTimer.howManyAddIron += addIronForCout;
            rockTimer.howManyAddRock += addRockForCout;
            woodTimer.howManyAddWood += addWoodForCout;

            wheatTimer.maxTimeWheat += addForMaxTimeWheat;
            ironTimer.maxTimeIron += addForMaxTimeIron;
            rockTimer.maxTimeRock += addForMaxTimeRock;
            woodTimer.maxTimeWood += addForMaxTimeWood;

            warehouseScript.NewLimitRock += addForLimitRock;
            warehouseScript.NewLimitIron += addForLimitIron;
            warehouseScript.NewLimitWheat += addForLimitWheat;
            warehouseScript.NewLimitWood += addForLimitWood;
            storageHome.NewLimitPeasant += addForLimitPeasant;

            wheatTimer.howManyWheat -= howManyNeedWheat;
            wheatTimer.howManyW.text = $"{wheatTimer.howManyWheat}";
            activateFarmDescription.infoAboutResourses.text = $"Пшеница:\nДобывается в 3 сек - {wheatTimer.howManyAddWheat}";

            ironTimer.howManyIron -= howManyNeedIron;
            ironTimer.howManyI.text = $"{ironTimer.howManyIron}";

            rockTimer.howManyRock -= howManyNeedRock;
            rockTimer.howManyR.text = $"{rockTimer.howManyRock}";

            woodTimer.howManyWood -= howManyNeedWood;
            woodTimer.howManyW.text = $"{woodTimer.howManyWood}";

            wheatTimer.howManyPeasant -= howManyNeedPeasant;
            peasantsScript.howManyP.text = $"{wheatTimer.howManyPeasant}";
        }
    }

    private void ChecingResourses()
    {
        if (wheatTimer.howManyWheat >= howManyNeedWheat &&
            ironTimer.howManyIron >= howManyNeedIron &&
            rockTimer.howManyRock >= howManyNeedRock &&
            woodTimer.howManyWood >= howManyNeedWood &&
            wheatTimer.howManyPeasant >= howManyNeedPeasant &&
            _canChecking && previousLVL.activeInHierarchy)
        {
            _canUpdating = true;
            buyButton.SetActive(true);
            buyButtonBG.SetActive(false);
        }
        else if (wheatTimer.howManyWheat <= howManyNeedWheat &&
            ironTimer.howManyIron <= howManyNeedIron &&
            rockTimer.howManyRock <= howManyNeedRock &&
            woodTimer.howManyWood <= howManyNeedWood &&
            wheatTimer.howManyPeasant <= howManyNeedPeasant &&
            _canChecking && previousLVL.activeInHierarchy)
        {
            _canUpdating = false;
            buyButton.SetActive(false);
            buyButtonBG.SetActive(true);
        }
    }
}
