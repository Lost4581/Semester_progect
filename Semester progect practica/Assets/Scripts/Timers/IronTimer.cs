using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IronTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyI;
    [SerializeField] private int maxTimeIron;
    [SerializeField] GameObject mine1;
    [SerializeField] GameObject mine2;
    [SerializeField] GameObject mine3;
    [SerializeField] GameObject mine4;
    [SerializeField] GameObject mine5;
    [SerializeField] GameObject mine6;
    [SerializeField] GameObject mine7;
    [SerializeField] GameObject mine8;
    [SerializeField] GameObject mine9;
    public int howManyIron;
    public int maxIron;
    float currTime;

    private void Start()
    {
        currTime = maxTimeIron;
        howManyI.text = "0";
    }
    private void Update()
    {
        if (mine1.activeInHierarchy || mine2.activeInHierarchy || mine3.activeInHierarchy || mine4.activeInHierarchy || mine5.activeInHierarchy 
        || mine6.activeInHierarchy || mine7.activeInHierarchy || mine8.activeInHierarchy || mine9.activeInHierarchy)
        {
            timerIron();
        }
            
    }
    public void timerIron()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeIron;
            AddIron(1);
        }
        if (howManyIron > maxIron)
        {
            howManyIron = maxIron;
            howManyI.text = $"{howManyIron}";
        }
    }
    public void AddIron(int value)
    {
        howManyIron += value;
        howManyI.text = $"{howManyIron}";
    }
}

