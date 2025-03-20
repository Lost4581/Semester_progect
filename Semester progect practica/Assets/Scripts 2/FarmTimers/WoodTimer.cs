using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI howManyW;
    [SerializeField] private List<GameObject> sawmills;
    [SerializeField] private int maxTimeWood;
    [SerializeField] private int howManyWood;
    [SerializeField] private int maxWood;
    [SerializeField] private int howManyAddWood;
    float currTime;

    private void Start()
    {
        currTime = maxTimeWood;
        howManyW.text = "0";
    }
    private void Update()
    {
        for (int i = 0; i < sawmills.Count; i++)
        {
            if (sawmills[i].activeInHierarchy)
            {
                timerWood();
            }
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
            AddWood(howManyAddWood);
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
