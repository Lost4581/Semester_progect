using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyW;
    [SerializeField] private int maxTimeWood;
    [SerializeField] GameObject sawmill1;
    [SerializeField] GameObject sawmill2;
    [SerializeField] GameObject sawmill3;
    [SerializeField] GameObject sawmill4;
    [SerializeField] GameObject sawmill5;
    [SerializeField] GameObject sawmill6;
    [SerializeField] GameObject sawmill7;
    [SerializeField] GameObject sawmill8;
    [SerializeField] GameObject sawmill9;
    public int howManyWood;
    public int maxWood;
    public int addWood;
    float currTime;


    private void Start()
    {
        currTime = maxTimeWood;
        howManyW.text = "0";
    }
    private void Update()
    {
        if (sawmill1.activeInHierarchy || sawmill2.activeInHierarchy || sawmill3.activeInHierarchy || sawmill4.activeInHierarchy || sawmill5.activeInHierarchy 
        || sawmill6.activeInHierarchy || sawmill7.activeInHierarchy || sawmill8.activeInHierarchy || sawmill9.activeInHierarchy)
        {
            timerWood();
        }
            
    }
    public void timerWood()
    {
        if (currTime >= 0)
        {
            currTime -= Time.deltaTime;
        }
        else
        {
            currTime = maxTimeWood;
            AddWood(addWood);
        }
        if (howManyWood > maxWood)
        {
            howManyWood = maxWood;
            howManyW.text = $"{howManyWood}";
        }
    }
    public void AddWood(int value)
    {
        howManyWood += value;
        howManyW.text = $"{howManyWood}";
    }
}
