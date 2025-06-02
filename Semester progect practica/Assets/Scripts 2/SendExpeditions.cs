using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SendExpeditions : MonoBehaviour
{

    [SerializeField] private WheatTimer wheatTimer;
    [SerializeField] private IronTimer ironTimer;
    [SerializeField] private RockTimer rockTimer;
    [SerializeField] private WoodTimer woodTimer;

    [SerializeField] private BuyScouts buyScouts;
    [SerializeField] private TextMeshProUGUI howManySec;

    [SerializeField] private int howManyAddWheat;
    [SerializeField] private int howManyAddIron;
    [SerializeField] private int howManyAddRock;
    [SerializeField] private int howManyAddWood;

    [SerializeField] private float howManyNeedScout;

    [SerializeField] private float startTime;
    private float _currTime;
    private bool _canSending = true;

    private void Start()
    {
        _currTime = startTime;
        _canSending = false;
    }

    private void Update()
    {
        howManySec.text = "";
        ExpeditionTimer();
    }

    public void SendExpedition()
    {
        if (buyScouts.HowManyScouts >= howManyNeedScout)
        {
            _canSending = true;
            buyScouts.HowManyScouts -= howManyNeedScout;
            buyScouts.howManyScouts.text = $"Исследователи: {buyScouts.HowManyScouts}/5";
        }
    }

    private void ExpeditionTimer()
    {
        if (_canSending && _currTime > 0)
        {
            _currTime -= Time.deltaTime;
            howManySec.text = $"{_currTime}";
        }
        else if (_currTime <= 0)
        {
            _canSending = false;
            _currTime = startTime;
            AddResourses();
        }
    }

    private void AddResourses()
    {
        wheatTimer.howManyWheat += howManyAddWheat;
        ironTimer.howManyIron += howManyAddIron;
        rockTimer.howManyRock += howManyAddRock;
        woodTimer.howManyWood += howManyAddWood;

        wheatTimer.howManyW.text = $"{wheatTimer.howManyWheat}";
        ironTimer.howManyI.text = $"{ironTimer.howManyIron}";
        rockTimer.howManyR.text = $"{rockTimer.howManyRock}";
        woodTimer.howManyW.text = $"{woodTimer.howManyWood}";
    }
}
