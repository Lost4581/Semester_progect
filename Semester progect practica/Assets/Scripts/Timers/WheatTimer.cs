using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WheatTimer: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyW;
    [SerializeField] private int maxTimeWheat;
    [SerializeField] GameObject mill1;
    [SerializeField] GameObject mill2;
    [SerializeField] GameObject mill3;
    [SerializeField] GameObject mill4;
    [SerializeField] GameObject mill5;
    [SerializeField] GameObject mill6;
    [SerializeField] GameObject mill7;
    [SerializeField] GameObject mill8;
    [SerializeField] GameObject mill9;
    public int howManyWheat;
    public int maxWheat;
    float currTime;


    private void Start()
    {
        currTime = maxTimeWheat;
        howManyW.text = "0";
    }
    private void Update()
    {
        if (mill1.activeInHierarchy || mill2.activeInHierarchy || mill3.activeInHierarchy || mill4.activeInHierarchy || mill5.activeInHierarchy 
        || mill6.activeInHierarchy || mill7.activeInHierarchy || mill8.activeInHierarchy || mill9.activeInHierarchy)
        {
            timerWheat();
        }
            
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
        if (howManyWheat > maxWheat)
        {
            howManyWheat = maxWheat;
            howManyW.text = $"{howManyWheat}";
        }
    }
    public void AddWheat(int value)
    {
        howManyWheat += value;
        howManyW.text = $"{howManyWheat}";
    }
}
