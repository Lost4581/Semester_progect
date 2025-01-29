using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WheatTimer: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyW;
    [SerializeField] private int maxTimeWheat; 
    public int howManyWheat = 0;
    float currTime;

    private void Start()
    {
        currTime = maxTimeWheat;
        howManyW.text = "0";
    }
    private void Update()
    {
        timerWheat();
    }
    public void timerWheat()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeWheat;
            AddWheat(1);
        }
        if (howManyWheat > 30)
        {
            howManyWheat = 30;
            howManyW.text = $"{howManyWheat}";
        }
    }
    public void AddWheat(int value)
    {
        howManyWheat += value;
        howManyW.text = $"{howManyWheat}";
    }
}
